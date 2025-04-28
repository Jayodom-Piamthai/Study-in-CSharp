using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder
{
    internal class stringBuilder
    {
        //C#, the string type is immutable. It means a string cannot be changed once created and stored in the heap.
        //by changing the initial string value c# will create a new string object on the memory heap instead of modifying an original string at the same memory address
        //this could hinder performance if done many times To solve this problem, C# introduced the StringBuilder in the System.Text namespace
        //StringBuilder doesn't create a new object in the memory but dynamically expands memory to accommodate the modified string
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); //string will be appended later
                                                    //or
            StringBuilder sbNeo = new StringBuilder("Hello World!");

            //you can also specify the maximum capacity of the StringBuilder object using overloaded constructors
            //***This capacity will automatically be doubled once it reaches the specified capacity 
            // You can also use the capacity or length property to set or retrieve the StringBuilder object's capacity
            StringBuilder sbb = new StringBuilder(50); //string will be appended later
                                                       //or
            StringBuilder sbc = new StringBuilder("Hello World!", 50);
            for (int i = 0; i < sbc.Length; i++)
                Console.Write(sb[i]); // output: Hello World!
            //retrive string 
            var greet = sb.ToString();
            Console.WriteLine(greet);
            //Use the Append() method to append a string at the end of the current StringBuilder object
            StringBuilder mad = new StringBuilder();
            mad.Append("Hello ");
            mad.AppendLine("World!");
            mad.AppendLine("Hello C#");
            Console.WriteLine(mad); // output would be : Hello World! Hello C#.

            //AppendFormat() input string into format and append
            StringBuilder sbAmout = new StringBuilder("Your total amount is ");
            sbAmout.AppendFormat("{0:C} ", 25);

            Console.WriteLine(sbAmout);//output: Your total amount is $ 25.00
            //insert remove replace
            sbNeo.Insert(5, " C#");
            Console.WriteLine(sbNeo);
            sbNeo.Remove(6, 7);
            Console.WriteLine(sbNeo);
            sbNeo.Replace("World", "C#");
            Console.WriteLine(sbNeo);
        }
    }
}
