using System.Threading.Tasks.Dataflow;

namespace Day2Assignment
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Polymorhism obj = new Polymorhism();
            Dog dog = new Dog();
            obj.sound();
            dog.sound();
            Console.ReadKey();
        }
    }
}