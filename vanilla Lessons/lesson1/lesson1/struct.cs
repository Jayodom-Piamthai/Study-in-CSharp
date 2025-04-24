using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class @struct
    {
        //struct is the value type data type that represents data structures. It can contain a parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.
        //struct can be used to hold small data values that do not require inheritance, e.g. coordinate points
        struct Coordinate
        {
            public int x;
            public int y;

            //method can be set too
            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Coordinate GetOrigin()
            {
                return new Coordinate(); //new coordinate will default at 0,0 so that is the value code may got from this
            }

        }


        //same as class,struct can auto implement properties
        struct LeSpot
        {
            public int x { get; set; }
            public int y { get; set; }

            //set default value to 0
            public void SetOrigin()
            {
                this.x = 0;
                this.y = 0;
            }

        }

        struct EventCoordinate
        {
            private int _x, _y; // _ prefix for private variable

            public int x
            {
                get
                {
                    return _x;
                }

                set
                {
                    _x = value;
                    CoordinatesChanged(_x);
                }
            }

            public int y
            {
                get
                {
                    return _y;
                }

                set
                {
                    _y = value;
                    CoordinatesChanged(_y);
                }
            }

            public event Action<int> CoordinatesChanged;
        }
        static void StructEventHandler(int point)
        {
            Console.WriteLine("Coordinate changed to {0}", point);
        }


        public static void Main()
        {
            //struct object can be created with or without the new operator
            Coordinate point = new Coordinate();
            Console.WriteLine(point.x); //output: 0  
            Console.WriteLine(point.y); //output: 0

            // struct type without using new keyword, it does not call any constructor, so all the members remain unassigned
            Coordinate Neopoint;
            Neopoint.x = 33;//value need to be assign after created and before use
            Neopoint.y = 66;
            Console.Write((Neopoint.x, Neopoint.y));

            LeSpot pointy = new LeSpot();
            pointy.SetOrigin();

            Console.WriteLine(pointy.x); //output: 0  
            Console.WriteLine(pointy.y); //output: 0

            //event handler 
            EventCoordinate Eventpoint = new EventCoordinate();

            Eventpoint.CoordinatesChanged += StructEventHandler;
            Eventpoint.x = 10;
            Eventpoint.y = 20;

        }




    }

}
