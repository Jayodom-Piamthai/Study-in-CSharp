using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        //interface can contain declarations of methods, properties, indexers, and events.However, it cannot contain instance fields
        interface IFile //It is recommended to start an interface name with the letter "I" at the beginning of an interface so that it is easy to know that this is an interface and not a class.
        {
            //Interface members are by default abstract and public
            //***kinda like making a prefab blueprint for multiple classes to use,so when class implement it they gotta use all method inside
            void ReadFile(); //created a method without a body
            void WriteFile(string text);
            //default implementation no need to setup inside class
            //version of c# is not enough(somehow),try running it in browser
            //void DisplayName()
            //{
            //    Console.WriteLine("IFile");
            //}
        }
        interface IBinaryFile
        {
            void OpenBinaryFile();
            void ReadFile();
        }

        class FileInfo : IFile //implementing IFIle
        {
            public void ReadFile() //this will now overide into IFile's ReadFile
            {
                Console.WriteLine("Reading File");
            }

            public void WriteFile(string text)
            {
                Console.WriteLine("Writing to file");
            }
        }
        class test : IFile
        {
            public void ReadFile() //this will now overide into IFile's ReadFile
            {
                Console.WriteLine("test 1 complete");
            }
            public void WriteFile(string text)
            {
                Console.WriteLine("test2 complete");
            }
        }
        //Explicit Implementation - useful when class is implementing multiple interfaces that coincidently have same method name so user wont get confuse
        //Do not use public modifier with an explicit implementation. It will give a compile-time error.
        class FileInfo2 : IFile
        {
            void IFile.ReadFile() //with this we know ReadFile method is from IFile interface without looking at the top
            {
                Console.WriteLine("Reading File");
            }
            void IFile.WriteFile(string text)
            {
                Console.WriteLine("Writing to file");
            }
            public void Search(string text) // new method unique to this class can add public
            {
                Console.WriteLine("Searching in file");
            }
        }

        //implement multiple interface at once
        class FileInfo3 : IFile, IBinaryFile
        {
            void IFile.ReadFile()//same name,different interface - explicit
            {
                Console.WriteLine("Reading Text File");
            }
            void IFile.WriteFile(string text)
            {
                Console.WriteLine("Writing to file");
            }

            void IBinaryFile.OpenBinaryFile()
            {
                Console.WriteLine("Opening Binary File");
            }

            void IBinaryFile.ReadFile()//same name,different interface - explicit
            {
                Console.WriteLine("Reading Binary File");
            }

            public void Search(string text)
            {
                Console.WriteLine("Searching in File");
            }
        }
        public static void Main()
        {
            IFile file1 = new FileInfo(); // ifile can access file info method as same as fileinfo can into itself
            FileInfo file2 = new FileInfo();
            test file3 = new test();
            IFile file4 = new test();


            file1.ReadFile();
            file1.WriteFile("content");

            file2.ReadFile();
            file2.WriteFile("content");

            file3.ReadFile();
            file3.WriteFile("content");

            file4.ReadFile();
            file4.WriteFile("content");


            //explicit - separate access from instance of interface
            //whatever was set in class will still applied,just separate access
            IFile file11 = new FileInfo2();//instance of Ifile can access all the method set in fileinfo2 but not the one that did not exist in IFile interface
            FileInfo2 file22 = new FileInfo2();//instance of FileInfo2 can access only the method not existed in IFile interface

            file11.ReadFile();
            file11.WriteFile("content");
            //file1.Search("text to be searched")//compile-time error 

            file22.Search("text to be searched");
            //file2.ReadFile(); //compile-time error 
            //file2.WriteFile("content"); //compile-time error 

            //multiple interfaces
            IFile file111 = new FileInfo3();
            IBinaryFile file222 = new FileInfo3();
            FileInfo3 file333 = new FileInfo3();

            file111.ReadFile();
            //file111.OpenBinaryFile(); //compile-time error 
            //file111.SearchFile("text to be searched"); //compile-time error 

            file222.OpenBinaryFile();
            file222.ReadFile();
            //file222.SearchFile("text to be searched"); //compile-time error 

            file333.Search("text to be searched");
            //file333.ReadFile(); //compile-time error 
            //file333.OpenBinaryFile(); //compile-time error 
        }
    }
}
