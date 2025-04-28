using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covariance
{
    internal class Program
    {

        // small is a base class for big and big is a base class for bigger.
        // The point to remember here is that a derived class will always have something more than a base class,
        // so the base class is relatively smaller than the derived class.

        //Covariance enables you to pass a derived type where a base type is expected. Co-variance is like variance of the same kind
        //Covariance in delegates allows flexiblity in the return type of delegate methods
        public delegate Small covarDel(Big mc);//this delegate expected a small class

        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }
        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }
        static Small Method3(Small sml) //this method have different parameter than delegate need(need big get small) but big is derived from small so its ok!
        {
            Console.WriteLine("Method3");

            return new Small();
        }
        static Big Method4(Small sml)
        {
            Console.WriteLine("Method4");

            return new Big();
        }


        static void Main(string[] args)
        {
            //Bigger class cannot derive from smaller class in the heirachy
            Small sml1 = new Big();   
            Small sml2 = new Bigger();   
            //Big big1 = new Small();//this will throw error - already derived
            Big big2 = new Bigger();

            //variance test
            covarDel del = Method1;

            Small sm1 = del(new Big());//create big from big parameter

            del = Method2;
            Small sm2 = del(new Big());//create small from big parameter

            //test 2
            del = Method1;
            del += Method2;
            del += Method3; // work just fine - small to create new big
            Small sm = del(new Big());

            //big small
            del = Method4;

            Small sm3 = del(new Big());//create big from small-which is what big is derived from : works fine
        }

        public class Small
        {

        }
        public class Big : Small //derived from small
        {

        }
        public class Bigger : Big //derived from big,that inherited from small
        {

        }
    }
}
