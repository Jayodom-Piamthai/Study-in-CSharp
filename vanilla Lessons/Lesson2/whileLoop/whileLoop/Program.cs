using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 0; // initialization

            //while loop continues until the conditional block return false
            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }

            //loop break
            while (true)
            {
                Console.WriteLine("i = {0}", i);
                i++;
                if (i > 10)
                    break;
            }

            //nested loop
            i = 0; int j = 1;

            while (i < 2)
            {
                Console.WriteLine("i = {0}", i);
                i++;

                while (j < 2)
                {
                    Console.WriteLine("j = {0}", j);
                    j++;
                }
            }

            //do-while - do once then start into the looping, guaranteeing that it will do at least once
            i = 0;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

            } while (i < 5);

            //do while breaking
            i = 0;
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

                if (i > 5)
                    break;

            } while (i < 10);

            //nested duwang
            i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);
                j = i;

                i++;

                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                } while (j < 2);

            } while (i < 2);

            //unlimited loop works
            while (i > 0)
            {
                Console.WriteLine("i = {0}", i);
                i++;
            }
        }
    }
}
