using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;


namespace Polymorphism
{
    /*A friend of yours wants to create a special calculator.
      He only wants two operations to be handled by that calculator
      i.e. : addition and subtraction.
      The calculator can only accept either 2 numbers or 3 numbers.

      There are two functionalities for this calculator -
      1. Normal -> in this role - the calculator works normally
      - where upon adding the numbers are added,
      while upon subtracting the numbers are subtracted.

      2. Opposite -> in this role - the calculator works opposite
      to the normal role - where upon adding the numbers are subtracted,
      while upon subtracting the numbers are added.
      That friend have approached you for the help, in creating
      such a calculator.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value1");
            int number1= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value2");
            int number2= Int32.Parse(Console.ReadLine());

            Normal obj = new Normal();  
            Normal obj1 = new Opposite();
            Console.WriteLine("Addition through normal method: ");
            Console.WriteLine(obj.add(number1, number2));
            Console.WriteLine("Subtraction through normal method: ");
            Console.WriteLine(obj.sub(number1, number2));
            Console.WriteLine("Addition through opposite method: ");
            Console.WriteLine(obj1.add(number1, number2 ));
            Console.WriteLine("subtraction through opposite method: ");
            Console.WriteLine(obj1.sub(number1, number2));
        }
    }
    class Normal  // Base class (parent) 
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    class Opposite : Normal  // Derived class (child) 
    {
        public int add(int a, int b)
        {
            return a - b;
        }
        public int sub(int a, int b)
        {
            return a + b;
        }
    }
}