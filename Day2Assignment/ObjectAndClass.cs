using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class ObjectAndClass
    {
        public void ClassAndObject()
        {
            Console.WriteLine("Enter the first value : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Value : ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Sum of two Value is : {first+second}");
        }
    }
}
