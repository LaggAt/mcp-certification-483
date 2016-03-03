using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Task t = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("t, i : " + i);
                }
            });
            t.ContinueWith((x) =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("t.ContinueWith, i : " + i);
                }
            });
            t.Start();
            t.Wait(); // equivalent to Thread.Join()

            Task<int> t2 = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine("t2.Result : " + t2.Result);

            // runs only on canceled
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, 
            TaskContinuationOptions.OnlyOnCanceled);

            // runs only on faulted
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            // runs only on completion
            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();

            Console.ReadLine();
        }
    }
}
