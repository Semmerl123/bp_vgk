using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_VGK.Tools
{
    public class Receptor
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _receptorName;

        public string ReceptorName
        {
            get { return _receptorName; }
            set { _receptorName = value; }
        }

        public Receptor()
        {
                
        }
        public override string ToString()
        {
            return ReceptorName;
        }

        public override bool Equals(object obj)
        {
            if (obj is Receptor)
            {
                Receptor r = (Receptor)obj;
                return (r.Id.Equals(this.Id) && r.ReceptorName.Equals(this.ReceptorName));

            }
            else return false;
        }


        private bool _isAvailable;

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }
    }
}
