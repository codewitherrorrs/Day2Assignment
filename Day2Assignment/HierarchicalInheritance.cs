using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class HierarchicalInheritance
    {
        public void sound()
        {
            Console.WriteLine("The Animals Sound are ");
        }  
    }
    public class Pig : HierarchicalInheritance
    {
        public void sound()
        {
            Console.WriteLine("Pig Say Wee Wee");
        }
    }
    public class Dog_One : HierarchicalInheritance
    {
        public void sound()
        {
            Console.WriteLine("Dog Say Bow Bow");
        }
    }
}
