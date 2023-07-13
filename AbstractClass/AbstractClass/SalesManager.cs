using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class SalesManager : Employee
    {
        readonly int id=10;
        public override void GetEmployeeDetails()
        {
            Console.WriteLine("in the overrided mwthod of the saleamnager");
        }

        public void SalesManagerInfo()
        {
            //id = 20;//cannot be modify
            Console.WriteLine("in the method of the Salesmanager info");
        }
    }
}
