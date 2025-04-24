using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class ifElse
    {   
        //if loop,you know the drill
        public static void Main()
        {
            int i = 10, j = 20;

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i == j)
            {
                Console.WriteLine("i is equal to j");
            }
            //alternate way - use method
            if (isGreater(i, j))
            {
                Console.WriteLine("i is less than j");
            }

            if (isGreater(j, i))
            {
                Console.WriteLine("j is greater than i");
            }

            //if else
            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }

            //nested loop
            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }
        }
        static bool isGreater(int i, int j)
        {
            return i > j;
        }
    }
}
