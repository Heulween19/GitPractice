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
            //ThreadPool.QueueUserWorkItem(ThreadProc);
            //Console.WriteLine("Main thread does some work, then sleeps.");
            //Thread.Sleep(1000);

            //Console.WriteLine("Main thread exits.");

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            MethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThread is : " +
                                 stopwatch.ElapsedTicks.ToString());

            stopwatch.Reset();
            Console.WriteLine("Execution using Thread Pool");
            stopwatch.Start();
            MethodWithThreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThreadPool is : " +
                                 stopwatch.ElapsedTicks.ToString());

            //Console.Read();


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

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void MethodWithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));
            }
        }

        static void MethodWithThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(ThreadProc);
                thread.Start();
            }

        }
    }
}
