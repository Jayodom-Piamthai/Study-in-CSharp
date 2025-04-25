using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueRef
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
        public void DisplayStudentInfo(int id)
        {
        }

    }
    internal class valueReff
    {
        //Value Type and Reference Type

        // data type is a VALUE TYPE if it holds a data value within its own memory space  It means the variables of these data types directly contain values
        // The following data types are all of value type:
        // bool
        //byte
        //char
        //decimal
        //double
        //enum
        //float
        //int
        //long
        //sbyte
        //short
        //struct
        //uint
        //ulong
        //ushort

        //Reference Type holds a pointer to the memory that holds the data needed instead of the value itself
        //The followings are reference type data types:
        //String
        //Arrays(even if their elements are value types)
        //Class
        //Delegate

        //When you pass a value-type variable from one method to another, the system creates a separate copy of a variable in another method.
        //If value got changed in the one method, it wouldn't affect the variable in another method
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }

        //When you pass a reference type variable from one method to another, it doesn't create a new copy; instead, it passes the variable's address
        //so when it goes through method its value will change from the method
        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }
        //String is a reference type, but it is immutable. It means once we assigned a value, it cannot be changed. If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location.
        //So, passing a string value to a function will create a new variable in the memory, and any change in the value in the function will not be reflected in the original value
        static void ChangeReferenceType(string name)
        {
            name = "Steve";
        }

        //null is a type of data that has not been initialized yet so null will not refer to anything
        static void Main(string[] args)
        {
            //value type test
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i); //change to 200 and display

            Console.WriteLine(i);//out of method change back to 100

            //reff type test
            Student std1 = new Student();
            std1.StudentName = "Bill";
            ChangeReferenceType(std1); //changed to steve
            Console.WriteLine(std1.StudentName);

            //string test
            string name = "Bill";
            ChangeReferenceType(name);//string is immutable so this will changes nothing
            Console.WriteLine(name);
        }
    }
}
