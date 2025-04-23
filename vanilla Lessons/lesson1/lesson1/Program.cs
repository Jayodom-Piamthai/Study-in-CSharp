
//refference to .net namespace 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//namespace name -> change with project name and folder name
namespace lesson1
{
    //name of class
    internal class Program
    {
        //method -> Main mean entry point for code
        static void Main(string[] args)
        {
            //code that will run inside
            string message = "sup world";
            Console.WriteLine(message);
        }

        //keywords
        //Modifier keywords are specific keywords that indicate who can modify types and type members EX) abstract async const new
        //Access modifiers are applied to the declaration of the class, method, properties, fields, and other members.They define the accessibility of the class and its members EX) public private
        //Statement keywords are related to program flow EX) if for foreach in switch
        //Method Parameter Keywords -> parameter for code - param ref out
        //Namespace Keywords These keywords are applied with namespace and related operators EX)namespace ::operator
        //Operator keywords perform miscellaneous actions EX) as await unchecked typeof sizeof
        //access keyword used to access the containing class or the base class of an object or class -> base this
        //Literal keywords apply to the current instance or value of an object EX) true false null
        //Type keywords are used for data types EX) bool int float
        //Contextual keywords are considered as keywords, only if used in specific contexts. They are not reserved and so can be used as names or identifiers EX) add var dynamic global
        //---->Contextual keywords are not converted into blue color
        //Query keywords are contextual keywords used in LINQ queries EX) from where join let equal

    }
}
