using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Practice
{
    internal class ClassA
    {
        //method overloading
        public int Add(int x,int y)
        {
            return x + y;
        }
        
        public int Add(int x,int y,int z)
        {
            return (x+y+z);
        }
        //params work as var-arg
        public int Add(params int[] arr)
        {
            int add = 0;
            foreach(int i in arr)
            {
                add = add + i;
            }
            return add;
        }
    }
}
