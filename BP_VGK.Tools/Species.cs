using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_VGK.Tools
{
    public class Species
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _designationTrivial;
       
        private string _designationScientific;

        private List<Receptor> _receptorList;

        public Species()
        {
            _receptorList = new List<Receptor>();
        }

                public string DesignationTrivial
        {
            get { return _designationTrivial; }
            set { _designationTrivial = value; }
        }

      
        public string DesignationScientific
        {
            get { return _designationScientific; }
            set { _designationScientific = value; }
        }

        public List<Receptor> ReceptorList
        {
            get { return _receptorList; }
            set { _receptorList = value; }
        }

    }
}
