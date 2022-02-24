using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(() =>
            {
                Console.WriteLine("Task on thread {0} started.",
                Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(3000);
                Console.WriteLine("Task on thread {0} finished.",
                Thread.CurrentThread.ManagedThreadId);
            });

            task.Start();
            Console.WriteLine("This is the main thread.");

            Task<int> task = new Task<int>(() =>
            {
                Thread.Sleep(3000);
                return 2 + 3;
            });


            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
