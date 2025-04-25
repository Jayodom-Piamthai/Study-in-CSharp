using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // _ IN FRONT OF VARIABLE MEAN IT IS PRIVATE VARIABLE


            //Variable names must be unique.
            //Variable names can contain letters, digits, and the underscore _ only.
            //Variable names must start with a letter.
            //Variable names are case-sensitive, num and Num are considered different names.
            //Variable names cannot contain reserved keywords.Must prefix @ before keyword if want reserve keywords as identifiers.
            int num = 100;
            float rate = 10.2f;
            decimal amount = 100.50M;
            char code = 'C';
            bool isValid = true;
            string name = "Steve";
            //cant assign out of type
            //int what = "no really, what";
            //can be declare first and assign/initialize later
            int number; // Declaration
            number = 10; // Initialization later
            Console.WriteLine(number); // Output: 10

            //int i;
            //int j = i; //compile-time error: Use of unassigned local variable 'i'

            int numy = 100;
            numy = 200;
            Console.WriteLine(numy); //output: 200

            //multiple declare
            int i, j = 10, k = 100;

            //assigning
            int id = 100;

            int ja = id + 20; // j = 120

            id = 200;
            ja = id + 20;// j = 220

            i = 300;
            Console.WriteLine("j = {0}", j);// j = 220

            //explicit/in=mplicit variable
            var free = 23;//var type is implicitly typed so it does not need to have type before assigning value,c# will give it to var whan compile
            //multiple declaration of var is not allowed
            //var i = 100, j = 200, k = 300; // Error: cannot declare var variables in a single statement

            //var cannot be used to store param
            //void Display(var param) //Compile-time error
            //{
            //    Console.Write(param);
            //}

            //var can be use in for loop
            for (var il = 0; il < 10; il++)
            {
                Console.WriteLine(i);
            }

            //var can also be used with LINQ queries
            // string collection
            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            // LINQ Query Syntax
            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;
            //The value of unsigned integers, long, float, double, and decimal type must be suffix by u,l,f,d, and m, respectively.
            uint ui = 100u;
            float fl = 10.2f;
            long l = 45755452222222l;
            ulong ul = 45755452222222ul;
            double d = 11452222.555d;
            decimal mon = 1000.15m;


            //Every data type has a default value. Numeric type is 0, boolean has false, and char has '\0' as default value. Use the default(typename) to assign a default value of the data type or C# 7.1 onward, use default literal.
            // C# 7.1 onwards
            int ii = default; // 0
            float ff = default;// 0
            decimal dd = default;// 0
            bool bb = default;// false
            char cc = default;// ''

            //The values of certain data types are automatically converted to different data types in C#. This is called an implicit conversion EX) int/float into string

            //byte bit short int long
            byte b1 = 255; // byte goes from 0-255 with no negative (8bit)
            sbyte sb1 = -128; //sbyte goes from -128 to 127 (8bit also)
            sbyte sb2 = 127;
            short s1 = -32768; //store numbers from -32,768 to 32,767 (16 bit)
            ushort us1 = 65535; //store numbers from 0 to 65,535(16 bit)
            int interger = 2147483647; //store number from -2,147,483,648 to 2,147,483,647(32 bit)
            uint ui1 = 4294967295; //store from 0 to 4,294,967,295
            //int can also store hex and binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;
            long l2 = 9223372036854775807; // long store numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807(64 bit)
            ulong ul1 = 18223372036854775808ul; //ulong type stores positive numbers from 0 to 18,446,744,073,709,551,615 . suffixed by UL, Ul, uL, ul, LU, Lu, lU, or lu
            float f1 = 123456.5F; //float store fractional numbers from 3.4e−038 to 3.4e+038. Use f or F suffix
            double d1 = 12345678912345.5d; // double store fractional numbers from 1.7e−308 to 1.7e+308. Use d or D suffix
            decimal d2 = 1.1234567891345679123456789123m;//decimal store fractional numbers from ±1.0 x 10-28 to ±7.9228 x 1028 suffix with  m or M
            //scientific notation Use e or E to indicate the power of 10 as exponent part of scientific notation with float, double or decimal
            double ddd = 0.12e2;
            Console.WriteLine(ddd);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000


        }
    }
}
