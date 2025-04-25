using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
    
        //In C#, an array can be of three types: single-dimensional, multidimensional, and jagged array
        //here will only be single dimension for now
        static void Main(string[] args)
        {
            //declaration
            int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };

            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            //var declaration - dont need square braacket
            var evenNumsVar = new int[] { 2, 4, 6, 8, 10 };

            var citiesVar = new string[] { "Mumbai", "London", "New York" };

            //size when declare is optional,you can do this type too 
            int[] evenNums2 = { 2, 4, 6, 8, 10 };

            string[] cities2 = { "Mumbai", "London", "New York" };

            //this is wrong
            //var what = { 1, 2, 3, 4, 5, 6, 7, };//var cannot initiazlize as array
            //int[] evenNums = new int[5] { 2, 4 }; //array size smaller than declared
            //int[] evenNums = new int[]; // if not gonna add value at *Initialization* need to add length
           
            int[] evenNumsLate; //*Declare* first then initialize later is OK
            evenNumsLate = new int[5]; //initialize
            // or
            evenNumsLate = new int[] { 2, 4, 6, 8, 10 };

            //accessing data
            evenNums[0] = 9;
            evenNums[1] = 33;
            //evenNums[6] = 12;  //Throws run-time exception IndexOutOfRange

            Console.WriteLine(evenNums[0]);  //prints 9
            Console.WriteLine(evenNums[1]);  //prints 33

            //loop access
            int[] evenNumsLoop = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < evenNumsLoop.Length; i++)
                Console.WriteLine(evenNumsLoop[i]);

            for (int i = 0; i < evenNumsLoop.Length; i++)
                evenNumsLoop[i] = evenNumsLoop[i] + 10;  // update the value of each element by 10
            //foreach
            Console.WriteLine("////FOREACH TEST///");
            foreach (var item in evenNums)
                Console.WriteLine(item);

            foreach (var city in cities)
                Console.WriteLine(city);

            //LINQ Methods
            Console.WriteLine("////LinqTest///");
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            nums.Max(); // returns 16
            nums.Min(); // returns 6
            nums.Sum(); // returns 55
            nums.Average(); // returns 55

            //methods
            Console.WriteLine("////MethodTest///");
            nums = new int[5] { 10, 15, 16, 8, 6 }; //reassign is available

            Console.WriteLine(nums); // this will print out type of variable- system.Int32[]
            Array.Sort(nums); // sorts array 
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            Array.BinarySearch(nums, 5);// binary search


            //parse array as an argument
            UpdateArray(nums);
            foreach (var item in nums)
                Console.WriteLine(item);
        }

        //array as an argument
        public static void UpdateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] + 10;
        }
    }

}
