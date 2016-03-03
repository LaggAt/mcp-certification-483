using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UsingConcurrentLists
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> bc = new BlockingCollection<int>();

            Task t1 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    bc.Add(5);
                    Console.WriteLine("t1");
                }
            });
            Task t2 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    bc.Take(0);
                    Console.WriteLine("t2");
                }
            });
            t1.Start();
            t2.Start();

            t1.Wait();
            t2.Wait();

            Console.WriteLine("bc.Count : " + bc.Count);

            Console.ReadLine();
        }
    }
}
