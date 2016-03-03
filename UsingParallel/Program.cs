using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 50, (i) =>
            {
                Console.WriteLine("i : " + i);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            Console.ReadLine();
        }
    }
}
