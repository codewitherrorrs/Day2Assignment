using System.Threading.Tasks.Dataflow;

namespace Day2Assignment
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            MethodOverloading obj = new MethodOverloading();
            obj.Method();
            obj.Method(50, 50);
            Console.ReadKey();
        }
    }
}