using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.Business
{
    public class HeadWaiter: Role
    {
        public decimal Salary {  get; set; }

        public HeadWaiter()
        {
            RoleVal= RoleType.HeadWaiter;
            Description = "Head Waiter";
            Salary = 0;
        }

        public override decimal Payment() => Salary;
       
    }
}
