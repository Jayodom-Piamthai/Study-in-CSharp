using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Program
    {
        //generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g.TypeName<T> where T is a type parameter.
        //generic means not specific to a particular data type
        class DataStore<T>
        {
            public T Data { get; set; }
        }
        //example2
        class KeyValuePair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }
        static void Main(string[] args)
        {
            //instantiation
            //by putting string type in the bracket T in the class turn into string
            DataStore<string> store = new DataStore<string>();
            store.Data = "Hello World!"; // and now it can store data!
            //store.Data = 123; //compile-time error - wrong type
        }
    }
}
