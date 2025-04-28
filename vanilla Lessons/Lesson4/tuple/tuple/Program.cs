using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tuple
{
    internal class Program
    {
        //USAGE
        //When you want to return multiple values from a method without using ref or out parameters.
        //When you want to pass multiple values to a method through a single parameter.
        //When you want to hold a database record or some values temporarily without creating a separate class.
        static void Main(string[] args)
        {
            //tuple is a data structure that contains a sequence of elements of different data types.
            //It can be used where you want to have a data structure to hold an object with properties,
            //but you don't want to create a separate type for it
            var person = Tuple.Create(1, "Steve", "Jobs");
            //tuple can hold a maximum of 8 elements
            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(numbers.Item4); // returns "Four"
            Console.WriteLine(numbers.Item5); // returns 5
            Console.WriteLine(numbers.Item6); // returns "Six"

            //nested tuples
            //numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13)); //dont reassign like this
            //dont matter what index is the nested tuple but reccomend to be the last index for readability
            var numbersNest = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbersNest.Item6); // returns "6"
            Console.WriteLine(numbersNest.Rest.Item1); //returns (8, 9, 10, 11, 12, 13) - nested tuple 1 - change index of tuple and it will still be item1
            Console.WriteLine(numbersNest.Rest.Item1.Item1); //returns 8 - item one of nested tuple 1


            //tuple ad argument parameter
            DisplayTuple(person);

            //return type
            person = GetPerson();
            Console.WriteLine(person);
        }
        static void DisplayTuple(Tuple<int, string, string> person) //type in tuple need to match type in each index inside tuple
        {
            Console.WriteLine($"Id = {person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }
        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "nyes");
        }
    }
}
