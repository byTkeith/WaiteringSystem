using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaiteringSystem.Business
{
    public class Employee:Person
    {
        public int EmployeeNumber{
            get; set;
        }
        public Role Role { get; set; }

        // the constructors
        public Employee(Role roleValue) {
            switch (roleValue.RoleVal) {
                case Role.RoleType.NoRole:
                    Role = new Role();
                    break;
                case Role.RoleType.HeadWaiter:
                    Role = new HeadWaiter();
                    break;
                case Role.RoleType.Waiter:
                    Role = new Waiter();
                    break;
                case Role.RoleType.Runner:
                    Role = new Runner();
                    break;
            }
        }
    }
}
