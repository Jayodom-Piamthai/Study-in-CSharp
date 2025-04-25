using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace generics
{
    internal class Program
    {
        //generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g.TypeName<T> where T is a type parameter.
        //generic means not specific to a particular data type
        class DataStore<T>
        {
            public T Data { get; set; }
            public T initing; //generic type cant be initialize
            public T[] deca = new T[10]; //but it can be declared
        }
        //example2
        class KeyValuePair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }

        //generic method
        class genericMethoder<T>
        {
            private T[] _data = new T[10]; //new private generic array called data with length of 10

            public void AddOrUpdate(int index, T item)
            {
                if (index >= 0 && index < 10)
                    _data[index] = item;
            }

            public T GetData(int index)
            {
                if (index >= 0 && index < 10)
                    return _data[index];
                else
                    return default(T);
            }
        }
        //overloading  - have method of same name with function that differs from other
        class overloader<T>
        {
            public void AddOrUpdate(int index, T data) { }
            public void AddOrUpdate(T data1, T data2) { }
            public void AddOrUpdate<U>(T data1, U data2) { }
            public void AddOrUpdate(T data) { }
        }

        //generic method in non generic class
        class Printer
        {
            public void Print<T>(T data)
            {
                Console.WriteLine(data);
            }
        }

        //class restraint
        class DataRestraint<T> where T : class //with this we can now you can only  parse class into this argument
        {
            public T Data { get; set; }
        }
        //struct restraint
        class DataStruct<T> where T : struct //this restraint make only non-nullable type parsable into this
        {
            public T Data { get; set; }
        }
        //new restraint
        class DataParabellum<T> where T : class, new()//new restraint allows only type that accept no parameter
        {
            public T Data { get; set; }
        }
        //base class restraint
        class DataBaseless<T> where T : IEnumerable//this restraint allow only specified class,abstract class,interfaces
        {
            public T Data { get; set; }
        }

        static void Main(string[] args)
        {
            //instantiation
            //by putting string type in the bracket T in the class turn into string
            DataStore<string> store = new DataStore<string>();
            store.Data = "Hello World!"; // and now it can store data!
            //store.Data = 123; //compile-time error - wrong type
            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
            //intStore.Data = "Hello World!"; // compile-time error

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>(); //key is now int , value is now string
            kvp1.Key = 100;
            kvp1.Value = "Hundred";

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();//both is now int
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";

            //generic method test
            genericMethoder<string> cities = new genericMethoder<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            genericMethoder<int> empIds = new genericMethoder<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            //generic method in non generic class
            Printer printer = new Printer();//instantiate an object of printer class 
            //calling print method , can specify type with code or let it be infer from value inserted
            printer.Print<int>(100); 
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value

            //restraint test
            //class restraint
            DataRestraint<string> store11 = new DataRestraint<string>(); // valid
            DataRestraint<MyClass> store22 = new DataRestraint<MyClass>(); // valid
            DataRestraint<IMyInterface> store33 = new DataRestraint<IMyInterface>(); // valid
            DataRestraint<IEnumerable> store44 = new DataRestraint<IEnumerable>(); // valid
            DataStore<ArrayList> store55 = new DataStore<ArrayList>(); // valid 
            //DataStore<int> store = new DataStore<int>(); // compile-time error

            //struct restraint
            DataStruct<int> store111 = new DataStruct<int>(); // valid
            DataStruct<char> store222 = new DataStruct<char>(); // valid
            DataStruct<MyStruct> store333 = new DataStruct<MyStruct>(); // valid

            //new restraint
            DataParabellum<MyClass> store1111 = new DataParabellum<MyClass>(); // valid
            DataParabellum<ArrayList> store2222 = new DataParabellum<ArrayList>(); // valid
            //DataStore<string> store = new DataStore<string>(); // compile-time error 
            //DataStore<int> store = new DataStore<int>(); // compile-time error 
            //DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // compile-time error

            //baseclass restraints
            DataBaseless<ArrayList> store11111 = new DataBaseless<ArrayList>(); // valid
            DataBaseless<List<string>> store22222 = new DataBaseless<List<string>>(); // valid
            DataBaseless<IEnumerable> store33333 = new DataBaseless<IEnumerable>(); // valid
            //DataStore<string> store = new DataStore<string>(); // compile-time error 
            //DataStore<int> store = new DataStore<int>(); // compile-time error 
            //DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // compile-time error 
            //DataStore<MyClass> store = new DataStore<MyClass>(); // compile-time error

        }

        private class MyClass
        {
        }

        private interface IMyInterface
        {
        }
        private struct MyStruct
        {
        }
    }
}
