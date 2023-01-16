using System;
using System.Diagnostics;
using System.Threading;

namespace Threadpool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue the task.
            ThreadPool.QueueUserWorkItem(ThreadProc);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(1000);

            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("ghkjnldmwl;md;ư");
            }   

            for (int i= 0;i < 10;i++)
            {
                Thread.Sleep(1000); 
            }    
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            MethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThread is : " +
                                 stopwatch.ElapsedTicks.ToString());




            Console.ReadKey();

        }

        private static void MethodWithThread()
        {
           Thread thread = new Thread(ThreadProc);
            thread.Start();
        }

        static void ThreadProc(object state)
        {
            // No state object was passed to QueueUserWorkItem, so stateInfo is null.
            Console.WriteLine("Hello from the thread pool.");
        }

        static void Printf()
        { Console.WriteLine("nokmceof"); }
    }
}
