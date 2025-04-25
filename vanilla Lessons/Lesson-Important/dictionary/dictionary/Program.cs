using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dictionary store a value by matching key and value (just like sorted list)
            //but it is not sorted;structure is like stack so it wont be ordered when display
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");//insert 2 later will not be sorted - order of display:1 3 2

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},//first value will be the key while the rest get collected as data value
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //accessing keys
            Console.WriteLine("accesing keys..."); //prints value of UK key
            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }

            //uodating 
            cities["UK"] = "Liverpool, Bristol,worchestershire"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException --does not exist,gotta make it first

            //adding
            cities.Add("France",
                       "Champagne");

            if (cities.ContainsKey("France")) //search for entry with key "france"
            {
                cities["France"] = "Paris,Champagne";
            }
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }

            //removal
            //cities.Remove("UK"); // removes UK 
            //                     //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            //if (cities.ContainsKey("France"))
            //{ // check key before removing it
            //    cities.Remove("France");
            //}

            //cities.Clear(); //removes all elements
        }
    }
}
