using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread with no parameter
            Thread t1 = new Thread(new ThreadStart(Method1));
            t1.Priority = ThreadPriority.Highest;
            t1.Start();
            t1.Join(); // waites until t1 continues executing

            Thread t2 = new Thread(new ThreadStart(Method2));
            t2.Start();
            t2.Priority = ThreadPriority.Lowest;

            // Thread with parameter
            Thread t3 = new Thread(new ParameterizedThreadStart(MethodWithParameter));
            t3.Start(100);

            // Creating Thread using Lambda Expression
            Thread t4 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("i : " + i);
                }
            }));
            t4.Start();

            // Method Main() is itself running on a Thread
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main() i : " + i);
            }

            Console.ReadLine();
        }
        static void Method1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Method # 1 , i : " + i);
            }
        }
        static void Method2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Method # 2 , i : " + i);
            }
        }
        static void MethodWithParameter(object obj)
        {
            // Important Tip
            object o = 20;
            var v = o.GetType(); // v : int (not Object)! 
            // returns the instanciated type, not the declared one
            
            if (obj is int)
            {
                int i = (int) obj;
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("MethodWithParameter(), j : " + j);
                }
            }
        }
    }
}
