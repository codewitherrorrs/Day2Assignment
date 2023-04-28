using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class MethodOverride
    {
        public virtual void Method()
        {
            int a = 20;
            int b = 20;
            Console.WriteLine($"The multiplication of a and b is : {a*b}");
        }
    }
    public class Derived : MethodOverride
    {
        public override void Method()
        {
            int a = 20; 
            int b = 20;
            Console.WriteLine($"The division of a and b is : {a / b}");
        }
    }
}
