using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerate
{
    internal class Program
    {
        //enum (or enumeration type) is used to assign constant names to a group of numeric integer values
        enum WeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }
        //number can also be assign to enum index
        enum Categories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }
        static void Main(string[] args)
        {
            //accessing enum
            Console.WriteLine(WeekDays.Monday); // Monday
            //conversion
            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int)WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 
            var wd = (WeekDays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday
        }
    }
}
