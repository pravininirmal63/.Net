using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractices
{
    internal class Swimmer : IPlayer, IPlayer2
    {
       

        public void walk()
        {
            Console.WriteLine("iplementation of the walk method");
        }

        public void walk2()
        {
            Console.WriteLine("Im[plementaion of walk2");
        }
    }
}
