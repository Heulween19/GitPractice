using System;
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



            Console.ReadKey();

        }

       static void ThreadProc(object state)
        {
            // No state object was passed to QueueUserWorkItem, so stateInfo is null.
            Console.WriteLine("Hello from the thread pool.");
        }

        static void Printf()
        { 
            Console.WriteLine("nokmceof"); 
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
    }
}
