using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WaiteringSystem.Business.Role;

namespace WaiteringSystem.Business
{
    public class Runner: Role
    {
        public decimal Rate { get; set; }
        public decimal Commission { get; set; }
        public decimal NoOfShifts { get; set; }

        //Constructor
        public Runner()
        {
            RoleVal = RoleType.Runner;
            Description = "Runner";
            Rate = 0;
            Commission = 0;
            NoOfShifts = 0;
        }

        public override decimal Payment()=>Rate*NoOfShifts;
        public override decimal Payment(decimal tips)=>Rate*NoOfShifts+tips;
      
    }
}
