using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Manager : Employee
    {
        public override void GetEmployeeDetails()
        {
            Console.WriteLine("overrided  method of manager..!!");
        }


        public void ManagerInfo()
        {
            Console.WriteLine("in the method of the manager info");
        }
    }
}
