using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class dateTIme
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(); // assigns default value 01/01/0001 00:00:00

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);

            //assigns year, month, day, hour, min, seconds
            //if it is out of range it will throw error EX) date over normal / seconds over 60
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            //Ticks is a date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001, at 00:00:00.000 in the Gregorian calendar
            DateTime dtt = new DateTime(636370000000000000);
            //DateTime.MinValue.Ticks;  //min value of ticks
            //DateTime.MaxValue.Ticks; // max value of ticks

            //static fields and property'DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            //timespan in day hours minutes
            DateTime dtn = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM

            //time subtraction
            DateTime dt111 = new DateTime(2015, 12, 31);
            DateTime dt222 = new DateTime(2016, 2, 2);
            TimeSpan result = dt2.Subtract(dt1);//33.00:00:00
            //datetime also supports +, -, ==, !=, >, <, <=, >= for easier operation!

            //A valid date and time string can be converted to a DateTime object using Parse(), ParseExact(), TryParse() and TryParseExact() if the string is valid
            var str = "5/12/2020";
            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

        }
    }
}
