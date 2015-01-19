using BP_VGK.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_VGK.Data.MSSQL
{
    public class DataProvider
    {
        private const string connectionString = @"Data Source=THOMAS-PC\SQLEXPRESS;Initial Catalog=BP_VGK.Database;Integrated Security=True";

        private static object _instanceLock = new object();

        private static DataProvider _instance = null;

        public static DataProvider GetInstance()
        {
            lock (_instanceLock)
            {
                if (_instance == null)
                    _instance = new DataProvider();
                return _instance;

            }
        }

        private SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);



            return conn;
        }

        public List<Receptor> GetReceptorsOfSpecies(Species s)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT ID, ReceptorName from ReceptorsTable where ID in (select Receptor_ID from SpeciesReceptor_Table where Species_ID=@specID);";
                cmd.Parameters.AddWithValue("specID", s.Id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<Receptor> receptorList = new List<Receptor>();
                    while (reader.Read())
                    {
                        Receptor r = new Receptor();
                        r.Id = new Guid(reader[0].ToString());
                        r.ReceptorName = Convert.ToString(reader[1]);
                        receptorList.Add(r);
                    }
                    return receptorList;
                }

            }
        }

        public List<Receptor> GetNotActivatedReceptorsOfSpecies(Guid speciesId)
        {
            List<Receptor> li = new List<Receptor>();

            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select ID, ReceptorName from ReceptorsTable where ID NOT IN (select Receptors_ID from SpeciesReceptor_Table where Species_ID=@sid) order by ReceptorName;";
                cmd.Parameters.AddWithValue("sid", speciesId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Receptor r = new Receptor();
                    r.Id = new Guid(reader[0].ToString());
                    r.ReceptorName = reader[1].ToString();
                    li.Add(r);
                }
            }
            return li;
        }


        public Species GetSpecies(Guid g)
        {
            Species s = null;

            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select ID, DesignationTrivial, DesignationScientific from SpeciesTable where ID=@gid;";
                cmd.Parameters.AddWithValue("gid", g);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    s = new Species();
                    s.Id = g;
                    s.DesignationTrivial = reader[1].ToString();
                    s.DesignationScientific = reader[2].ToString();
                }
                else return null;
                conn.Close();
                conn.Open();
                //now get all receptors of it
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select ID, ReceptorName from ReceptorsTable where ID in (select Receptors_ID from SpeciesReceptor_Table where Species_ID=@sid) order by ReceptorName;";
                cmd2.Parameters.AddWithValue("@sid", g);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    Receptor r = new Receptor();
                    r.Id = new Guid(reader2[0].ToString());
                    r.ReceptorName = reader2[1].ToString();
                    s.ReceptorList.Add(r);

                }
            }
            return s;
        }


        public void UpdateSpecies(Species s)
        {

            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                //first delete all given receptors from species_receptorlist
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM SpeciesReceptor_Table where Species_ID=@sid";
                cmd.Parameters.AddWithValue("sid", s.Id);
                cmd.ExecuteNonQuery();


                foreach (Receptor r in s.ReceptorList)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO SpeciesReceptor_Table (Species_ID, Receptors_ID) VALUES(@sid, @rid);";
                    cmd.Parameters.AddWithValue("sid", s.Id);
                    cmd.Parameters.AddWithValue("rid", r.Id);
                    cmd.ExecuteNonQuery();
                }

                //now update Trivial and Scientific Name
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE SpeciesTable SET DesignationTrivial=@desTri, DesignationScientific=@desSci where ID=@sid";
                cmd.Parameters.AddWithValue("desTri", s.DesignationTrivial);
                cmd.Parameters.AddWithValue("desSci", s.DesignationScientific);
                cmd.Parameters.AddWithValue("sid", s.Id);
                cmd.ExecuteNonQuery();


                conn.Close();
            }


        }


        private DataProvider()
        {

        }

        public void DeleteReceptor(Receptor receptor)
        {

            if (receptor == null) return;
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM ReceptorsTable where Id=@rid;";
                    cmd.Parameters.AddWithValue("rid", receptor.Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }


        public void AddOrUpdateReceptor(Receptor receptor)
        {
            if (receptor == null)
                return;
            if (receptor.Id == Guid.Empty)
            {
                //new receptor
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO ReceptorsTable (ReceptorName) VALUES (@recName);";
                        cmd.Parameters.AddWithValue("recName", receptor.ReceptorName);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            else
            {
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE ReceptorsTable set ReceptorName=@recName WHERE Id=@rid;";
                        cmd.Parameters.AddWithValue("recName", receptor.ReceptorName);
                        cmd.Parameters.AddWithValue("rid", receptor.Id);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();


                }

            }
        }
    }
}
