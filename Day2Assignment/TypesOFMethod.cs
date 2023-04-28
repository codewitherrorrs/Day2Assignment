using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class TypesOFMethod
    {
        //Method Without Parameter.
        public void Method()
        {
            string firstName = "Sagar";
            string secondName = "Shahu";
            Console.WriteLine($"Full Name : {firstName +" "+ secondName}");
        }
        //Method With Parameter.
        public void Method_One(string firstName, string secondName)
        {
            Console.WriteLine($"Full Name : {firstName} {secondName}");
        }
        //Method With Return Type.
        public string Method_Two(string firstName, string secondName)
        {
            return "Full Name : "+firstName +" "+secondName;
        }
    }
}
