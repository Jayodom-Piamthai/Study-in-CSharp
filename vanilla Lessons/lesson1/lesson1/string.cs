using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class @string
    {
        static void Main(string[] args)
        {

            //two ways to declare string
            string str1 = "Hello"; // uses string keyword
            String str2 = "Hello"; // uses System.String class

            //array into string
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            string str11 = new string(chars);
            String str22 = new String(chars); 

            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }

            //backspace can be use to help display special charactor
            string text = "This is a \"string\" in C#.";
            string str = "xyzdef\\rabc";
            string path = "\\\\mypc\\ shared\\project";
            //or verbatim assiging by prefix @ infront of the string
            string str = @"xyzdefabc";
            string path = @"\mypcsharedproject";
            string email = @"test@test.com";
            //@ can also be use to declare multi line strings
            string str123 = "this is a " + 
                "multi line " + 
                "string";

            // Verbatim string
            string str223 = @"this is a 
        multi line 
        string";
            // "" still need to use """" to display properly
            string text = "This is a "string" in C#."; // valid
            string texttest1 = @"This is a "string" in C#."; // error
            string texttest2 = @"This is a ""string"" in C#."; // valid

            //Multiple strings can be concatenated with + operator.
            string name = "Mr." + "James " + "Bond" + ", Code: 007";

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;
            //f string / interpolation
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

        }
    }
}
