using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Practice
{
    internal class Ferrari : Cars
    {
        private readonly int numberOfExhaust;

        public Ferrari(int id, string color, double price) : base(id, color, price)
        {
            //this.numberOfExhaust = numberOfExhaust;
        }

        public int Number
        {
            get { return numberOfExhaust; }
            //set { numberOfExhaust = value; }
        }

        public void MyMethod()
        {
            //numberOfExhaust = 100;
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Exhaust: " + numberOfExhaust;
        }
    }
}