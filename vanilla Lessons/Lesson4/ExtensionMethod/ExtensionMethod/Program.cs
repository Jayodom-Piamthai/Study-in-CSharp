using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;//like this! but this one is already ExtensionMethod so it does not really need it

namespace ExtensionMethod //if you want to use this method anywhere else add: "using ExtensionMethod " (this namespace) at the top of project
{


    public static class Program //class need to be a static if we want to make a custom extension method
    {
        //Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface
        // extension method is actually a special kind of static method defined in a static class. To define an extension method
        public static bool IsGreaterThan(this int i, int value) //declare a new method
        {
            return i > value;
        }

        static void Main(string[] args)
        {


            int i = 10;

            //bool result = i.IsGreaterThan(100); //returns false
        }
    }
}
