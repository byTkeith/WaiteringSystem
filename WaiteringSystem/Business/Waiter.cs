using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WaiteringSystem.Business
{
    public class Waiter: Role
    {
        public decimal Rate { get; set; }
        public decimal Tips {  get; set; }
        public decimal NoOfShifts { get; set; }

        //the constructores
        public Waiter() { 
            RoleVal=RoleType.Waiter;
            Description = "Waiter";
            Rate = 0;
            Tips = 0;
            NoOfShifts = 0;
        }

        //overide payments
        public override decimal Payment(decimal tips)=>Rate*NoOfShifts+tips;
       
    }
}
