using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class static_class
    {
        //Apply the static modifier before the class name and after the access modifier to make a class static
        //You cannot create an object of the static class; therefore the members of the static class can be accessed directly using a class name
        //All the members of a static class must be static; otherwise the compiler will give an error
        //The normal class (non-static class) can contain one or more static methods, fields, properties, events and other non-static members
        public static class Calculator
        {
            private static int _resultStorage = 0;

            public static string Type = "Arithmetic";

            public static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }

            public static void Store(int result)
            {
                _resultStorage = result;
            }
        }

        //static method in non static class
        public class StopWatch
        {
            public static int NoOfInstances = 0;

            // instance constructor
            public StopWatch()
            {
                StopWatch.NoOfInstances++;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                StopWatch sw1 = new StopWatch();
                StopWatch sw2 = new StopWatch();
                Console.WriteLine(StopWatch.NoOfInstances); //2 

                StopWatch sw3 = new StopWatch();
                StopWatch sw4 = new StopWatch();
                Console.WriteLine(StopWatch.NoOfInstances);//4
            }
        }
    }
    //static method
    class staticMethod
    {
        static int counter = 0;
        string name = "Demo Program";

        static void Main(string[] args)
        {
            counter++; // can access static fields
            Display("Hello World!"); // can call static methods

            name = "New Demo Program"; //Error: cannot access non-static members
            SetRootFolder("C:MyProgram"); //Error: cannot call non-static method
        }

        static void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void SetRootFolder(string path) { }
    }
}
