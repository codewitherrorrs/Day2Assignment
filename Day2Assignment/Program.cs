using System.Security.Cryptography.X509Certificates;
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
            /*   Encapsulation obj= new Encapsulation();
               Console.WriteLine($"Name : {obj.Name = "Abhishek"}");
               Console.WriteLine($"Standard : {obj.Standard = "Graduate"}");
            */
            /* TypesOFMethod obj = new TypesOFMethod();
             obj.Method();
             obj.Method_One("Shreya","Ma'am");
             Console.WriteLine(obj.Method_Two("Abhishek","Tara"));
             Console.ReadKey(); */
            //Reference And Value type.
            /*  int value = 20;
              int value_One = 40;
              ValueAndRefType obj = new ValueAndRefType();
              obj.Method(value,value_One);
              obj.Method_One(ref value,value_One); */

            //Single Inheritence
            /*   Child child= new Child();
               child.ShowMethod(); 
            */
            //Multilevel Inheritance
          /*  ChildOne child = new ChildOne();
            ChildTwo childTwo = new ChildTwo();
            child.ShowMethod();
            childTwo.ShowMethod(); */

            //Hierarchical Inheritance
         /*   Dog_One dog = new Dog_One();
            Pig pig = new Pig();
            dog.sound();
            pig.sound();
            Console.ReadKey(); */

            //Multiple Inheritance
          /*  Derived_One obj = new Derived_One();
            obj.Show();
            obj.ShowMethod(); */
        }
    }
}