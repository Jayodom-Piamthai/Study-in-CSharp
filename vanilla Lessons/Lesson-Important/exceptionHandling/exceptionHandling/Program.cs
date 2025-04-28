using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for exception list please refer to this site : https://www.tutorialsteacher.com/csharp/csharp-exception
            //Exceptions in the application must be handled to prevent crashing of the program and unexpected result,
            //log exceptions and continue with other functionalities with try catch finally block
            
            //Any suspected code that may raise exceptions should be put inside a try block
            try 
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            //exception handler block where you can perform some action such as logging and auditing an exception - if try fails it goes here
            //catch block should include a parameter of a built-in or custom exception class to get an error detail - note that it is optional
            catch( Exception ex )
            {
                Console.Write("Error occurred. : ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name); //get name of exception that can use in catch later
            }
            //will ALWAYS be executed whether an exception raised or not. Usually, a finally block should be used to release resources
            finally 
            {
                Console.WriteLine("Re-try with a different number.");
            }




            //exception filters -- catch specific errorss
            //parameterless catch can only have 1 existed at a time
            Console.Write("Please enter a number to divide 100: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }


            //nested catch
            var divider = 0;
            //inner catch will run first to catch null ref
            //but if it cant catch - the process will flow outward to outer catch and find a proper exception filter 
            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }

            //throw - activating exception manually with customizable exception message
            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

            //re-throw - method 2 will throw which will be catch by method1 that will throw again can catch by main tryCatch here
            //error message will also display the line it errors from by using stacktrace
            //using catch parameter in catch layer will not preserve original exception and create new one
            //so use catch parameter only at the top layer
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }
        private static void PrintStudentName(Student std)
        {
            if (std == null) 
                throw new NullReferenceException("Student object is null."); //custom message for exception

            Console.WriteLine(std.studentName);
        }
        class Student
        {
            public string studentName;
            public int studentID;
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static void Method2()
        {
            string str = null;
            try
            {
                Console.WriteLine(str[0]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
