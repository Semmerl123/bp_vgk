using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_VGK.Tools
{
    public class Gene
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _name_of_protein;

        public string Name_of_protein
        {
            get { return _name_of_protein; }
            set { _name_of_protein = value; }
        }

        private string _documentation;

        public string Documentation
        {
            get { return _documentation; }
            set { _documentation = value; }
        }

        private string _pathToFile;

        public string PathToFile
        {
            get { return _pathToFile; }
            set { _pathToFile = value; }
        }


        public Gene()
        {

        }


    }
}
