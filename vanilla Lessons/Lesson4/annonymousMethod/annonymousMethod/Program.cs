using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annonymousMethod
{
    internal class Program
    {
        public delegate void Print(int value);

        //anonymous method as delegateS 
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }

        static void Main(string[] args)
        {
            //unnamed method for quick usage
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);

            //can be defined in other function too
            int i = 10;

            Print prnt = delegate (int val)
            {
                val += i;
                Console.WriteLine("Anonymous method: {0}", val);
            };

            PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);

            //limitTION
            //It cannot contain jump statement like goto, break or continue.
            //It cannot access ref or out parameter of an outer method.
            //It cannot have or access unsafe code.
            //It cannot be used on the left side of the is operator

        }
    }
}
