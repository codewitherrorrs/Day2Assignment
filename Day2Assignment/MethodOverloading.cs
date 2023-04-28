using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class MethodOverloading
    {
        public void Method()
        {
            int a = 20;
            int b = 30;
            Console.WriteLine($"The sum of a and b : {a+b}");
        }
        public void Method(int a , int b)
        {
            Console.WriteLine($"The sum of a and b is : {a + b}");
        }

    }
}
