using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class ternary
    {
        public static void ternaryTest()
        {
            int x = 20, y = 10, z = 5;

            //..think of if as an advance if statement
            var result = x > y ? "x is greater than y" : "x is less than y"; //result change with operation and string at the end

            Console.WriteLine(result);//output : x is greater than y

            //nested ternary
            string result2 = x > y ? "x is greater than y" ://if false then do the later part
                    x < y ? "x is less than y" :
                        x == y ? "x is equal to y" : "No result";

            Console.WriteLine(result2);

            //The ternary operator is right-associative. The expression a ? b : c ? d : e is evaluated as a ? b : (c ? d : e), not as (a ? b : c) ? d : e
            //so calculate from right to left
            var result3 = x * 3 > y ? x : y > z ? y : z;
            Console.WriteLine(result3);
        }
    }
}
