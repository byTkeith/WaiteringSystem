using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem
{
    public abstract class Person
    {   //region for data members
        #region Data Members
        private string id;
        private string name;
        private int phone;
        #endregion

        //region for properties
        #region Property Methods
        public string ID{
            get { return id; }
            set { id = value; }
        }

        public string Name{ 
            get { return name; } 
            set { name = value; } 
        }

        public string Name 
            { 
            get { return name; }
            set { id = value; }

        }

        public int Phone { 
            get { return phone; }
            set { phone = value; }
        }
        #endregion

        //region for constructors
    }
}
