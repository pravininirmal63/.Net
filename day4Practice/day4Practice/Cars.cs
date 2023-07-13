using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Practice
{
    internal class Cars
    {
        private int id;
        private string color;
        private double price;
        public Cars()
        {
            Console.WriteLine("in the cars default constryxdtor ");
        }
        public Cars(int id, string color, double price)
        {
            Console.WriteLine("in the cars paramerterised constryxdtor ");
            this.id = id;
            this.color = color;
            this.price = price;
        }

        public int Id
        {
            get {
                return id;           
            }

            set
            {
                id = value;
            }
        }

        public int MyProperty { get; set; }

        ~ Cars()
        {
            Console.WriteLine("in the cars desdtrtuctor of the cars");
        }

        public void MyMethod()
        {
            Console.WriteLine("in the method of the cars");
        }
        
    }
}
