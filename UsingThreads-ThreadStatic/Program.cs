using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreads_ThreadStatic
{
    class Program
    {

        [ThreadStatic]
        static int _field = 0;

        static void Main(string[] args)
        {
          
            Thread t1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    _field++;
                    Console.WriteLine("t1, _field : " + _field);
                }
            }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    _field++;
                    Console.WriteLine("t2, _field : " + _field);
                }
            }));
            t2.Start();
           
            Thread.Sleep(2000);

            Console.ReadLine();
        }
    }
}
