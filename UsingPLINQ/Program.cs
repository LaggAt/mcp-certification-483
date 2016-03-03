using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 50);

            var r = numbers.AsParallel().AsOrdered().Where((i) => i % 2 == 0).ToArray();
            var r2 = numbers.AsParallel().AsOrdered().Where((i) => i % 2 == 0);
            var r3 = numbers.AsParallel().AsOrdered().Where((i) => i % 2 == 0).AsSequential();

            foreach (var i in r)
            {
                Console.WriteLine("i : " + i);
            }

            r2.ForAll(e => Console.WriteLine(e));

            Console.ReadLine();
        }
    }
}
