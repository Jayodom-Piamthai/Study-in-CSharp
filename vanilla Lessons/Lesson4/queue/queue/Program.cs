using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first in first out data type
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id); //prints 1234

            //dequeue - remove from queue
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");
            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            //first in first out
            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); //prints Hello

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0

            //peeking - see the front of the queue
            Console.WriteLine(callerIds.Peek()); //prints 1

            //contains -- check existance in queue
            callerIds.Contains(2); //true
            callerIds.Contains(10); //false
        }
    }
}
