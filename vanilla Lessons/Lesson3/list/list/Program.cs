using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list is a generic collection of data so type need to be specified before data can be stored when declare
            List<int> primeNumbers = new List<int>(); //declare as int list
            primeNumbers.Add(2); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            //custom class object in list
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            //adding array in list
            string[] newcities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(newcities);//add at the end of empty list no need for index

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);

            //accessing List
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); // prints 1
            Console.WriteLine(numbers[1]); // prints 2
            Console.WriteLine(numbers[2]); // prints 5
            Console.WriteLine(numbers[3]); // prints 7

            // using foreach LINQ method
            numbers.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);

            //insertion
            numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.Write(num);
            Console.WriteLine("");
            Console.WriteLine("removal test");
            //removal
            numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list -> select from RIGHT TO LEFT (maybe it was kept in a stack)

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0) -> from left to right

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers)
                Console.Write(el); //prints 20 30

            //check existance
            numbers = new List<int>() { 10, 20, 30, 40 };
            numbers.Contains(10); // returns true
            numbers.Contains(11); // returns false
            numbers.Contains(20); // returns true
        }

        private class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
