using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predicateDelegate
{
    internal class Program
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        static void Main(string[] args)
        {
            //It represents a method containing a set of criteria and checks whether the passed parameter meets those criteria
            //take one parameter in then return a boolean
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);

            //annonymous method
            Predicate<string> isUpper2 = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result2 = isUpper2("hello world!!");

            //lambda
            Predicate<string> isUpper3 = s => s.Equals(s.ToUpper());
            bool result3 = isUpper("hello world!!");
        }
    }
}
