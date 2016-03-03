using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask_Parent
{
    class Program
    {
        static void Main(string[] args)
        {

            // using parent task
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];

                new Task(() =>
                {
                    results[0] = 0;
                },
                TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[1] = 1,
                TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[2] = 2,
                TaskCreationOptions.AttachedToParent).Start();

                return results;
            });
            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (int i in parentTask.Result)
                {
                    Console.WriteLine("parentTask.Result : " + i);
                }
            });

            finalTask.Wait();

            // using TaskFactory
            Task<Int32[]> parent2 = Task.Run(() =>
            {
                var results = new Int32[3];
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 10);
                tf.StartNew(() => results[1] = 20);
                tf.StartNew(() => results[2] = 30);

                return results;
            });
            var finalTask2 = parent2.ContinueWith(parentTask =>
            {
                foreach (int i in parentTask.Result)
                {
                    Console.WriteLine("results[] : " + i);
                }
            });
            finalTask2.Wait();


            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            }
            );
            Task.WaitAll(tasks);
            //Task.WaitAny(tasks); // waites for the first completed task

            int managedThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("managedThreadIdmanagedThreadId : " + managedThreadId);

            Console.ReadLine();
        }
    }
}
