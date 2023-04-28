using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public interface MultipleInheritance
    {
       public void Show();
    }
    public interface Interface_Child
    {
       public void ShowMethod();
    }
    public class Derived_One : MultipleInheritance, Interface_Child
    {
       public void Show()
        {
            Console.WriteLine("Hii i am Interface One Method");
        }

        void MultipleInheritance.Show()
        {
            throw new NotImplementedException();
        }

     public void ShowMethod()
        {
            Console.WriteLine("Hii i am Interface Second Method");
        }

        void Interface_Child.ShowMethod()
        {
            throw new NotImplementedException();
        }
    }
}
