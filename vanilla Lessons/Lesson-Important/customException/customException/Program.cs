using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace customException
{
    internal class Program
    {
        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
        }
        [Serializable]
        //new class of custom exception for specific funtion
        class InvalidStudentNameException : Exception //name of exception
        {
            public InvalidStudentNameException() { }//exception with no message

            public InvalidStudentNameException(string name)//if throw with message this will activate
                : base(String.Format("Invalid Student Name: {0}", name))
            {

            }
        }
        static void Main(string[] args)
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))//if name contain forbidden charactor - throw custom exception with name as parameter
                throw new InvalidStudentNameException(std.StudentName);


    }
    }
}
