using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class MultilevelInheritance
    {
        public void ShowMethod()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"MultilevelInheritance Inheritance Method : {a+b}");
        }
    }
    public class ChildOne : MultilevelInheritance
    {

    }
    public class ChildTwo : ChildOne
    {

    }
}
