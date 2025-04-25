using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList<TKey, TValue>,
            //and SortedList are collection classes that can store key-value pairs that are sorted by the keys based on the associated IComparer implementation

            //SortedList of int keys, string values 
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            //The following will throw exceptions
            //numberNames.Add("Three", 3); //Compile-time error: key must be int type
            //numberNames.Add(1, "One"); //Run-time exception: duplicate key
            //numberNames.Add(null, "Five");//Run-time exception: key cannot be null

            ////Creating a SortedList of string keys, string values 
            //using collection-initializer syntax
            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };
            
            //default sorting order
            SortedList<int, string> numberNames2 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames2)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames2.Add(6, "Six");
            numberNames2.Add(2, "Two");
            numberNames2.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames2)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            //even if the order of insertion is scuffed,it will order by default

            //accessing list
            SortedList<int, string> numberNames3 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

            Console.WriteLine(numberNames3[1]); //output: One
            Console.WriteLine(numberNames3[2]); //output: Two
            Console.WriteLine(numberNames3[3]); //output: Three
                                                //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

            numberNames3[2] = "TWO"; //updates value
            numberNames3[4] = "Four"; //adds a new key-value if a key does not exists
            Console.WriteLine(numberNames3[4]); //output: Four

            //check existance
            SortedList<int, string> numberNames4 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
            if (numberNames4.ContainsKey(4)) //check if index with key 4 exist
            {
                numberNames4[4] = "four";
            }

            string result;
            if (numberNames4.TryGetValue(4, out result)) // try to get index with key 4 and its value
                Console.WriteLine("Key: {0}, Value: {1}", 4, result);

            //iterations
            SortedList<int, string> numberNames5 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
            for (int i = 0; i < numberNames5.Count; i++)
            {
                //thi will go through index of sorted list one by one
                Console.WriteLine("key: {0}, value: {1}", numberNames5.Keys[i], numberNames5.Values[i]);
            }
        }
    }
}
