using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        //stack is last in first out data collection type

        static void Main(string[] args)
        {
            //create new stack and add value
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            //last in first out
            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1,

            //stack from array
            Console.WriteLine("");
            Console.WriteLine("//array stack");
            int[] arr = new int[] { 1, 2, 3, 4 };
            myStack = new Stack<int>(arr);
            //still last in first out index 3 to index 0
            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1,

            //poping 
            Console.WriteLine("");
            Console.WriteLine("//poping");
            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            //peeking -see the top value in the stack
            myStack.Push(1);
            myStack.Push(3);
            myStack.Push(5);
            myStack.Push(7);
            Console.WriteLine(myStack.Peek()); // prints 7

            //contains - check for existance in the stack
            Console.WriteLine(myStack.Contains(3)); // returns true
            Console.WriteLine(myStack.Contains(10)); // returns false
        }
    }
}
