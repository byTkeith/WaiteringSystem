using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.Business
{
    public class Role
    {
        public enum RoleType { NoRole, HeadWaiter, Waiter, Runner}
        public RoleType RoleVal { get; set; }
        public string Description {  get; set; }

        //default constructor
        public Role() { 
            RoleVal = RoleType.NoRole;
            Description = "No role";
        }

        //Overrideable methods
        public virtual decimal Payment()
        {
            return 0;
        }
        public virtual decimal Payment(decimal tips) { 
            return 0;
        }
    }
}
