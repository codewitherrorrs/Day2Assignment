using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class ValueAndRefType
    {
        //Value Type
        public void Method(int first,int second)
        {
            Console.WriteLine($"Sum : {first + second}");
        }

        //Reference Type  
        public void Method_One(ref int first , int second)
        {
            Console.WriteLine($"Reference Sum : {first + second}");
        }
    }
}
