using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace @event
{
    internal class Program
    {
        //An event is a wrapper around a delegate. It depends on the delegate

        //Notify delegate specifies the signature for the ProcessCompleted event handler
        public delegate void Notify();  // delegate

        public class ProcessBusinessLogic
        {
            //any event should include two parameters
            public event Notify ProcessCompleted; // event

            // declaring an event using built-in EventHandler
            public event EventHandler ProcessCompleted2;

            // declaring an event using built-in EventHandler - use to parse data 
            public event EventHandler<bool> ProcessCompleted3;

            // declaring an event using built-in EventHandler - use for custom event arg
            public event EventHandler<ProcessEventArgs> ProcessCompleted4;

            //normal event 
            public void StartProcess()
            {
                Console.WriteLine("Process Started!");
                // some code here..
                OnProcessCompleted();//if all goes well this will be called after process above
            }

            protected virtual void OnProcessCompleted() //protected virtual method
            {
                //if ProcessCompleted is not null then call delegate
                ProcessCompleted?.Invoke();
            }

            ////built in event handler delageate test
            public void StartProcess2()
            {
                Console.WriteLine("Process Started!");
                // some code here..
                OnProcessCompleted2(EventArgs.Empty); //No event data
            }

            protected virtual void OnProcessCompleted2(EventArgs e)
            {
                ProcessCompleted2?.Invoke(this, e);
            }

            ////parse data test
            public void StartProcess3()
            {
                try
                {
                    Console.WriteLine("Process Started!");

                    // some code here..

                    OnProcessCompleted3(true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    OnProcessCompleted3(false);
                }
            }
            protected virtual void OnProcessCompleted3(bool IsSuccessful)
            {
                ProcessCompleted3?.Invoke(this, IsSuccessful);
            }



            ////custom event arg
            public void StartProcess4()
            {
                var data = new ProcessEventArgs();

                try
                {
                    Console.WriteLine("Process Started!");

                    // some code here..

                    data.IsSuccessful = true;
                    data.CompletionTime = DateTime.Now;
                    OnProcessCompleted4(data);
                }
                catch (Exception ex)
                {
                    data.IsSuccessful = false;
                    data.CompletionTime = DateTime.Now;
                    OnProcessCompleted4(data);
                }
            }

            protected virtual void OnProcessCompleted4(ProcessEventArgs e)
            {
                ProcessCompleted4?.Invoke(this, e);
            }



        }

        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
        // event handler - built in event handler
        public static void bl_ProcessCompleted2(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }

        // event handler - event data parser
        public static void bl_ProcessCompleted3(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }

        // event handler - custom event argument parsing
        public static void bl_ProcessCompleted4(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
        }




        static void Main(string[] args)
        {
            //An event can be declared in two steps:
            //Declare a delegate.
            //Declare a variable of the delegate with event keyword.
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.StartProcess();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
            //process : startprocess() -> OnProcessCompleted() -> processComplete evoked -> bl_ProcessCompleted()

            //build in handler test
            Console.WriteLine("BUILT IN HANDLER TEST");
            bl.ProcessCompleted2 += bl_ProcessCompleted2; // register with an event
            bl.StartProcess2();

            //event data parsing
            Console.WriteLine("data parse");
            bl.ProcessCompleted3 += bl_ProcessCompleted3; // register with an event
            bl.StartProcess3();

            //custom event argument
            Console.WriteLine("CUSTOM EVENT ARG");
            bl.ProcessCompleted4 += bl_ProcessCompleted4; // register with an event
            bl.StartProcess();

        }


        public class ProcessEventArgs : EventArgs //custom event arguments
        {
            public bool IsSuccessful { get; set; }
            public DateTime CompletionTime { get; set; }
        }
    }
}
