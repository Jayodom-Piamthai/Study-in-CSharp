using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            //anonymous type is a type (class) without any name that can contain public read-only properties only. It cannot contain other members, such as fields, methods, events, etc.
            //create an anonymous type using the new operator with an object initializer syntax VAR
            //The properties can be accessed using dot (.) notation, same as object properties. However, you cannot change the values of properties as they are read-only
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student.LastName); //accessing internal value - output: Bond
            //student.Id = 2;//Error: cannot chage value
            //student.FirstName = "Steve";//Error: cannot chage value

            //anonymous type's property can include another anonymous type or array
            var studentAnny = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };
            var students = new[] {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }
            };

            //An anonymous type will always be local to the method where it is defined. It cannot be returned from the method. However, an anonymous type can be passed to the method as object type parameter, but it is not recommended
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
        };

            var studentsu = from s in studentList
                            select new { Id = s.StudentID, Name = s.StudentName };


            foreach (var studs in studentsu)
            {
                Console.WriteLine(studs.Id + "-" + studs.Name);
            }
            //output 1-John 2 - Steve 3 - Bill 4 - Ram 5 - Ron
            //Although your code cannot access it. Use GetType() method to see the internal name
            Console.WriteLine(student.GetType().ToString());




            //Dynamic type - avoids compile-time type checking and check it at runtime
            dynamic MyDynamicVar = 1;
            Console.WriteLine(MyDynamicVar.GetType()); //output :System.Int32
            //dynamic variable changes type based on assigned value
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType()); //Value: 100, Type: System.Int32
            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType()); //Value: Hello World!!, Type: System.String
            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType()); //Value: True, Type: System.Boolean
            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType()); //Value: 01-01-2014, Type: System.DateTime

            //The dynamic type variables is converted to other types implicitly
            dynamic d1 = 100;
            int i = d1;
            //change to string
            d1 = "Hello";
            string greet = d1;
            //change to datetime
            d1 = DateTime.Now;
            DateTime dt = d1;
            //for dynamic type compiler would not check for correct methods and properties name of a dynamic type that holds the custom class object
            dynamic stud = new Student();

            stud.DisplayStudentInfo(1, "Bill");// run-time error, no compile-time error
            stud.DisplayStudentInfo("1");// run-time error, no compile-time error
            stud.FakeMethod();// run-time error, no compile-time error




            // Nullable Types -  allow you to assign null to value type variables. You can declare nullable types using Nullable<t>where T is a type
            //normal type wont allow null
            //The Nullable types are instances of System.Nullable < T > struct
            Nullable<int> nullInt = null;
            if (nullInt.HasValue)
                Console.WriteLine(nullInt.Value); // or Console.WriteLine(nullInt)
            else
                Console.WriteLine("Null");
            //nullable is just like anyother variable but with flag to say its null and let compiler do the rest
            //Accessing the value using NullableType.value will throw a runtime exception if nullable type is null or not assigned any value
            //Use the GetValueOrDefault() method to get an actual value if it is not null and the default value if it is null
            Console.WriteLine(nullInt.GetValueOrDefault()); // output : 0 (default for int)

            int? mysterio = null; //shorthand - use ? to suffix variable type,can use on some certain variable 
            Console.WriteLine(mysterio);
            int j = mysterio ?? 0;//assign a nullable type to a non-nullable type
            Console.WriteLine(j);
            //nullable will return error if accessed without assigning a value first 
            Console.WriteLine(nullInt);//this will error
            MyClass mycls = new MyClass();
            if (mycls.i == null)//if its null from class it will not throw error
                Console.WriteLine("Null");
            //Null is considered to be less than any value.So comparison operators won't work against null
            j = 10;
            if (nullInt < j)
                Console.WriteLine("nullInt < j");
            else if (nullInt > 10)
                Console.WriteLine("nullInt > j");
            else if (nullInt == 10)
                Console.WriteLine("nullInt == j");
            else
                Console.WriteLine("Could not compare");
            //Nullable static class is a helper class for Nullable types. It provides a compare method to compare nullable types. It also has a GetUnderlyingType method that returns the underlying type argument of nullable types
            if (Nullable.Compare<int>(nullInt, j) < 0)
                Console.WriteLine("nullInt < j");
            else if (Nullable.Compare<int>(nullInt, j) > 0)
                Console.WriteLine("nullInt > j");
            else
                Console.WriteLine("nullInt = j");
        }
        class MyClass
        {
            public Nullable<int> i;
        }
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int age { get; set; }
            public void DisplayStudentInfo(int id)
            {
            }

        }

    }
}
