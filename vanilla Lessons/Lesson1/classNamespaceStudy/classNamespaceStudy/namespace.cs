using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//import namespaces , allowing import from other folder and directory inside the project
using namespaceStudy;
//import inner namespaces - folder
using namespaceStudy.folder;
namespace namespaceStudy
{
    internal class study
    {
        //Classes under the same namespace can be referred to as namespace.classname syntax. For example, the Student class can be accessed as NewName.
        class Program
        {
            static void Main(string[] args)
            {
                namespaceStudy.newName jayson = new namespaceStudy.newName();
                Console.WriteLine("testing");
            }
        }
    }
}
