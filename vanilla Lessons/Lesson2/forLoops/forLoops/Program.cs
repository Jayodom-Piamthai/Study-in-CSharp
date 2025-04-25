using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    internal class Program
    {
        public static void Main()
        {
            int i, j, k;
            //loop start from 0 to 9 stopping at 10 with 1 increment 1 up every round
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }



            //type can be varied
            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i: {0}", d);
            }

            //reverse loop
            for (j = 10; j > 0; j--)
            {
                Console.WriteLine("Value of j: {0}", j);
            }

            //break out condition
            for (k = 0; k < 10; k++)
            {
                if (k == 5)
                    break;

                Console.WriteLine("Value of k: {0}", k);
            }

            //multiple condition
            for (i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }

            //statements
            i = 0; j = 5;
            for (Console.WriteLine($"Initializer: i={i}, j={j}");
                i++ < j--;
                Console.WriteLine($"Iterator: i={i}, j={j}"))
            {
            }

            //nested loops
            for (i = 0; i < 2; i++)
            {
                for (j = i; j < 4; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }

            //initializer,condition,stepper - all are conditional and not mandatory so this is possible and results in infinite loop
            for (; ; )
            {
                Console.Write(1);
            }

        }
    }
}
