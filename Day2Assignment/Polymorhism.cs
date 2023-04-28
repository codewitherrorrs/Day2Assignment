using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class Polymorhism
    {
        public void sound()
        {
            Console.WriteLine("The Animals Sound are ");
        }
    }

    public class Dog : Polymorhism 
    {
        public void sound()
        {
            Console.WriteLine("Dog Say Bow Bow");
        }
    }
}
