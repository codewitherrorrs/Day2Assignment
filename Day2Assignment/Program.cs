using System.Threading.Tasks.Dataflow;

namespace Day2Assignment
{
    public class Program
    {
        public static void Main(string[] args) 
        {
           /* MethodOverride obj = new MethodOverride();
            obj.Method();
            Derived obj_One = new Derived();
            obj_One.Method(); */
            Encapsulation obj= new Encapsulation();
            Console.WriteLine($"Name : {obj.Name = "Abhishek"}");
            Console.WriteLine($"Standard : {obj.Standard = "Graduate"}");
            Console.ReadKey();
        }
    }
}