using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        //dalegate allow function to be parse as a paremeter by defining a method signature
        public delegate void MyDelegate(string msg);

        public delegate int MyIntDelegate(); //declaring a delegate

        public delegate T add<T>(T param1, T param2); // generic delegate


        static void Main(string[] args)
        {
            // set target method
            MyDelegate delTest = new MyDelegate(MethodA);
            // or 
            //MyDelegate del = MethodA;
            // or set lambda expression 
            //MyDelegate del = (string msg) => Console.WriteLine(msg);

            //invoking a delegate
            delTest.Invoke("Hello World!");
            // or 
            delTest("Hello World!");

            MyDelegate del = ClassA.MethodA;
            del("Hello World A");

            del = ClassB.MethodB;
            del("Hello World B");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World C");

            //delagate as parameter
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            InvokeDelegate(del);

            //multiple delegate
            Console.WriteLine("MULTIPLE DELEGATE");
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate delaware = del1 + del2; // combines del1 + del2
            delaware("Hello World");//this called both delegate at once

            Console.WriteLine(" DELEGATE OPERATION ");
            MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            delaware += del3; // combines del1 + del2 + del3
            delaware("Hello World");

            delaware = delaware - del2; // removes del2
            delaware("Hello earth");

            delaware -= del1; // removes del1
            delaware("Hello dirt");


            //if multiple delegate returns a value,the last one activated will be the value returned
            MyIntDelegate del1a = ClassA.MethodAA;
            MyIntDelegate del2b = ClassB.MethodBB;

            MyIntDelegate delab = del1a + del2b;
            Console.WriteLine(delab());// returns 200

            //using generic delegate
            add<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            add<string> con = Concat;
            Console.WriteLine(Concat("Hello ", "World!!"));


        }
        static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }

        // target method
        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
        class ClassA
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
            public static int MethodAA()
            {
                return 100;
            }
        }
        class ClassB
        {
            public static void MethodB(string message)
            {
                Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
            }
            public static int MethodBB()
            {
                return 200;
            }
        }

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }

}
