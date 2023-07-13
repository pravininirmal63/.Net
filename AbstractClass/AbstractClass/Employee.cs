using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class Employee
    {
        public abstract void GetEmployeeDetails();
        public void MyMethod()
        {
            Console.WriteLine("in the abstract class method");
        } 
    }
}
