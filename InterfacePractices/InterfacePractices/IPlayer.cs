using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractices
{
    internal interface IPlayer
    {
        void walk();

        public void run()
        {
            Console.WriteLine("instant method");
        }
    }
}
