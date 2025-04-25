using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaceStudy
{
    //class is like a blueprint that define functunality ,property ,fields etc of object
    /// <summary>
    /// /can be accessed by other part of program depend on access modifier
    /// </summary>
    public class ClassStudy
    {
        //fields. It is a class-level variable that holds a value
        public string Name = "ace";
        private int id = 2; //private cant be access directly , use get set below to set value

        //property encapsulates a private field using setter and getter to assign and retrieve underlying field value
        public int StudentId
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        //backing private field for the FirstName and LastName will be created internally by the compiler. This speed up the development time and code readability. no need to declare private
        class newName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        //method can contain one or more statements to be executed as a single unit. A method may or may not return a value. A method can have one or more input parameters.
        //think of it as func in py or js
        public int Sum(int num1, int num2)
        {
            var total = num1 + num2;

            return total;
        }

        //method type void does not return any value
        public void Greet()
        {
            Console.Write("Hello World!");
        }
        //constructor is a special type of method which will be called automatically when you create an instance of a class , must have same name as class name and cannot return value/type
        //only one parameterless constructor can exist but multiple parameter one can exist at the same time
        //if none are present c# will make one internally

    }

    public class newName
    {
        //backing private field for the FirstName and LastName will be created internally by the compiler. This speed up the development time and code readability. no need to declare private
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //object of a class -> create new object of a class with new, allowing the property inside bo be accessed
        public newName Neuman = new newName();
        //accesing property
        public newName()
        {
            Neuman.FirstName = "Neuman";
        }

    }
}
