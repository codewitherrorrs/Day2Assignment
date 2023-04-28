using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public abstract class Abstractionclass
    {
        public abstract void Method();
        public void Method_One()
        {
            Console.WriteLine("Account Number is 444555666");
        }
    }
    public class AbstractChild : Abstractionclass
    {
        public override void Method()
        {
            Console.WriteLine("Hii My IFSC Code is : 444859955");
        }
    }
}
