using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    internal class Program
    {

        //indexer is a special type of property that allows a class or a structure to be accessed like an array for its internal collection.
        //C# allows us to define custom indexers, generic indexers, and also overload indexers

        //indexer can be defined the same way as property with this keyword and square brackets []
        class StringDataStore
        {
            private string[] strArr = new string[10]; // internal data storage
            public string this[int index]
            {
                get
                {
                    if (index < 0 || index >= strArr.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                    return strArr[index];
                }
                set
                {
                    if (index < 0 || index >= strArr.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                    strArr[index] = value;
                }
            }
        }

        //new version of syntax from c# 7.0 onward
        class StringDataStore2
        {
            private string[] strArr = new string[10]; // internal data storage

            public string this[int index]
            {
                get => strArr[index];

                set => strArr[index] = value;
            }
        }
        //generic indexer can be use with any types of data
        class DataStore<T>
        {
            private T[] store;
            public DataStore()
            {
                store = new T[10];
            }
            public DataStore(int length)
            {
                store = new T[length];
            }
            public T this[int index]
            {
                get
                {
                    if (index < 0 && index >= store.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                    return store[index];
                }

                set
                {
                    if (index < 0 || index >= store.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                    store[index] = value;
                }
            }
            public int Length
            {
                get
                {
                    return store.Length;
                }
            }
        }

        //overloading indexer
        class StringDataStore4
        {
            private string[] strArr = new string[10]; // internal data storage

            // int type indexer
            public string this[int index]
            {
                get
                {
                    if (index < 0 || index >= strArr.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                    return strArr[index];
                }

                set
                {
                    if (index < 0 || index >= strArr.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                    strArr[index] = value;
                }
            }

            // string type indexer
            public string this[string name]
            {
                get
                {
                    foreach (string str in strArr)
                    {
                        if (str.ToLower() == name.ToLower())
                            return str;
                    }

                    return null;
                }
            }
        }


        static void Main(string[] args)
        {

            //utilizing indexer
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);


            //generic indexer showcase
            DataStore<int> grades = new DataStore<int>();
            grades[0] = 100;
            grades[1] = 25;
            grades[2] = 34;
            grades[3] = 42;
            grades[4] = 12;
            grades[5] = 18;
            grades[6] = 2;
            grades[7] = 95;
            grades[8] = 75;
            grades[9] = 53;

            for (int i = 0; i < grades.Length; i++)
                Console.WriteLine(grades[i]);

            DataStore<string> names = new DataStore<string>(5);
            names[0] = "Steve";
            names[1] = "Bill";
            names[2] = "James";
            names[3] = "Ram";
            names[4] = "Andy";

            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);

            //overloading indexer
            StringDataStore4 strStoreovr = new StringDataStore4();

            strStoreovr[0] = "One";
            strStoreovr[1] = "Two";
            strStoreovr[2] = "Three";
            strStoreovr[3] = "Four";

            Console.WriteLine(strStoreovr["one"]);
            Console.WriteLine(strStoreovr["two"]);
            Console.WriteLine(strStoreovr["Three"]);
            Console.WriteLine(strStoreovr["Four"]);
        }
    }
}
