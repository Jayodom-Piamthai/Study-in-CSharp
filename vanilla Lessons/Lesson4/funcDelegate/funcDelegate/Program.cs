using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcDelegate
{

    public delegate T add<T>(T param1, T param2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //func delegate allows two(or more) input parameter
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);

            //annonymous method
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

            //lambda expression
            Func<int> getRandomNumberLambda = () => new Random().Next(1, 100);
            //or
            Func<int, int, int> Summit = (x, y) => x + y;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
    }

}
