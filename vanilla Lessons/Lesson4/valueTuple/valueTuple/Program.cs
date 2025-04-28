using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using () you can create tuple without using tuple.create
            var person = (1, "Bill", "Gates");

            //equivalent Tuple
            //var person = Tuple.Create(1, "Bill", "Gates");

            //specifying type
            (int, string, string) person2 = (1, "Bill", "Gates");
            Console.WriteLine(person2.Item1);  // returns 1
            Console.WriteLine(person2.Item2);  // returns bill
            Console.WriteLine(person2.Item3);  // returns gates

            //tuple REQUIRE 2 member and up 
            var number = (1);  // int type, NOT a tuple
            var numbers = (1, 2); //valid tuple
            //value tuple can hold MORE THAN 8 values!
            var numberssss = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            //we can also assign name to the value - like so
            (int Id, string FirstName, string LastName) person3 = (1, "Bill", "nyes");
            Console.WriteLine(person3.Id);   // returns 1
            Console.WriteLine(person3.FirstName);  // returns "Bill"
            Console.WriteLine(person3.LastName); // returns "Gates"
            //this works too
            person = (Id: 1, FirstName: "Bill", LastName: "Gates");

            //name and type assignment take left side as more important - if you want to assign both name and type,do it on the same side
            // PersonId, FName, LName will be ignored.
            (int Id, string FirstName, string LastName) personel = (PersonId: 1, FName: "Bill", LName: "Gates");

            //variable assignment
            string firstName = "Bill", lastName = "Gates";
            var personAssign = (FirstName: firstName, LastName: lastName);

            //parse as parameter
            DisplayTuple((1, "Bill", "Gates"));

            //return method assignment
            person = GetPerson();
            Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);

            //return type
            var personReturn = GetPerson2();
            Console.WriteLine("{0}, {1}, {2}", personReturn.Id, personReturn.FirstName, personReturn.LastName);

            //deconstruction - retrieve members of tuples
            // change property names
            (int PersonId, string FName, string LName) = GetPersonOut();
            // use var as datatype
            (var PersonIdVar, var FNameVar, var LNameVar) = GetPersonOut2();
            // use discard _ for the unused member LName
            (var id, var Name, _) = GetPerson();


        }

        static void DisplayTuple((int, string, string) personParse)
        {
            //tuple parameter - assign type for parameter and placeholder name for parameter tuple as "personParse"
            Console.WriteLine("{0}, {1}, {2}", personParse.Item1, personParse.Item2, personParse.Item3);
        }

        static (int, string, string) GetPerson()
        {
            return (1, "willem", "dafoe");
        }

        static (int Id, string FirstName, string LastName) GetPerson2()
        {
            return (Id: 1, FirstName: "Bill", LastName: "Gates");
        }
        static (int, string, string) GetPersonOut()
        {
            return (Id: 1, FirstName: "Bill", LastName: "Gates");
        }
        static (int, string, string) GetPersonOut2()
        {
            return (Id: 1, FirstName: "Bill", LastName: "Gates");
        }
    }
}
