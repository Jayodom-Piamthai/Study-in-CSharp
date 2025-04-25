using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//use for arrayList

namespace arrayList
{
    internal class Program
    {
        public static void showAll(ArrayList list,string listName)
        {
            //var listName = nameof(list);
            Console.WriteLine($"///showing indexes of list: {listName}///");
            foreach (var ar in list)
            {
                Console.WriteLine(ar);
            }

        }
        //ArrayList is a non-generic collection of objects whose size increases dynamically. It is the same as Array except that its size increases dynamically
        static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList();
            // or 
            var arlistVar = new ArrayList(); // recommended - prob for flexibility

            //arrayList showcase
            // adding elements using ArrayList.Add() method
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };

            showAll(arlist1,"arlist1" );
            showAll(arlist2,"arlist2" );

            //Use the AddRange(ICollection c) method to add an entire Array, HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList
            var arlist11 = new ArrayList();

            var arlist22 = new ArrayList()
                    {
                        1, "Bill", " ", true, 4.5, null
                    };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist11.AddRange(arlist22); //adding arraylist in arraylist 
            arlist11.AddRange(arr); //adding array in arraylist 
            arlist11.AddRange(myQ); //adding Queue in arraylist
            showAll(arlist11, "arlist11");

            //Access individual item using indexer
            int firstElement = (int)arlist11[0]; //returns 1
            string secondElement = (string)arlist11[1]; //returns "Bill"
            //int secondElement = (int) arlist[1]; //Error: cannot cover string to int

            //using var keyword without explicit casting
            var firstElement1 = arlist1[0]; //returns 1
            var secondElement2 = arlist1[1]; //returns "Bill"
            //var fifthElement = arlist[5]; //Error: Index out of range

            //update elements
            arlist1[0] = "Steve";
            arlist1[1] = 100;
            //arlist[5] = 500; //Error: Index out of range

            //itteration

            Console.WriteLine("////ITTERATIONS"); //output: 1, Bill, 300, 4.5, 
            foreach (var item in arlist1)
                Console.WriteLine(item + ", "); //output: 1, Bill, 300, 4.5, 

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i] + ", "); //output: 1, Bill, 300, 4.5,

            //insertion
            arlist1.Insert(1, "Second Item");

            foreach (var val in arlist1)
                Console.WriteLine(val);
            //InsertRange() method to insert a collection in an ArrayList at the specfied index
            arlist1.InsertRange(2, arlist2); // insert indexes from arlist 2 into arlist1 at the position of index 2
            showAll(arlist1, "arlist1");
            //removAL
            arlist1.Remove(null); //Removes first occurance of null
            arlist1.RemoveAt(4); //Removes element at index 4
            arlist1.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            //check existance
            Console.WriteLine(arlist.Contains(300)); // true
            Console.WriteLine(arlist.Contains("Bill")); // true

            //additional properties
            // Capacity     Gets or sets the number of elements that the ArrayList can contain.
            //Count         Gets the number of elements actually contained in the ArrayList.
            //IsFixedSize   Gets a value indicating whether the ArrayList has a fixed size.
            //IsReadOnly    Gets a value indicating whether the ArrayList is read - only.
            //Item          Gets or sets the element at the specified index.


        }
    }
}
