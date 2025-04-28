using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    internal class Program
    {
        //Hashtable is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection
        //It optimizes lookups by computing the hash code of each key and stores it in a different bucket internally and then matches
        //the hash code of the specified key at the time of accessing values
        static void Main(string[] args)
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //dictionary into hashtable
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht = new Hashtable(dict);
            Console.WriteLine(ht[1]);

            //table update
            //creating a Hashtable using collection-initializer syntax
            cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            string citiesOfUK = (string)cities["UK"]; //cast value to string
            string citiesOfUSA = (string)cities["USA"]; //cast value to string

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            //removal
            cities.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            cities.Clear(); //removes all elements
            Console.WriteLine(cities["UK"]);
        }
    }
}
