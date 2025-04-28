using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actionDelegate
{
    internal class Program
    {
        //An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value
        //good to use with void method + quick short and easy
        public delegate void Print(int val);

        static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(10);
            //or with no define up top
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
            //Or assign a method directly
            Action<int> printActionDel2 = new Action<int>(ConsolePrint);
            //or lambda
            Action<int> printActionDel3 = i => Console.WriteLine(i);
            printActionDel3(10);
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}
