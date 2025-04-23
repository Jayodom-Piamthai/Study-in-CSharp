using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//import namespaces , allowing import from other folder and directory inside the project
using lesson1;
//import inner namespaces
using lesson1.folder;

namespace lesson1
{
    //A namespace is a container for classes and namespaces. The namespace also gives unique names to its classes thereby you can have the same class name in different namespaces
    //namespace name change with solution name and folder name EX from model folder namespace will be : lesson1.model
    internal class namespaceStudy
    {

        //Classes under the same namespace can be referred to as namespace.classname syntax. For example, the Student class can be accessed as NewName.
        class Program
        {
            static void Main(string[] args)
            {
                lesson1.newName jayson =new lesson1.newName();
                //Console.WriteLine("testing");
            }
        }
    }
}
