using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStopWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Algorithm1();

            stopwatch.Stop();

            Console.WriteLine("stopwatch.Elapsed.TotalMilliseconds : " + stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 100; i++)
            {
                Algorithm2(i);
            }

            Console.WriteLine("stopwatch.Elapsed.TotalMilliseconds : " + stopwatch.Elapsed.TotalMilliseconds);

            UsingPerformanceCounters();

            Console.ReadLine();
        }

        /// <summary>
        /// This method uses PerformanceCounter class to get available memory size.
        /// </summary>
        private static void UsingPerformanceCounters()
        {
            Console.WriteLine("Press escape key to stop");
            using (PerformanceCounter pc = new PerformanceCounter("Memory", "Available Bytes"))
            {
                string text = "Available memory: ";
                Console.Write(text);
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Write(pc.RawValue);
                        Console.SetCursorPosition(text.Length, Console.CursorTop);
                    }
                }
                while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
        }

        private static void Algorithm2(int i)
        {
            Console.WriteLine("i : " + i);
        }

        private static void Algorithm1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i : " + i);
            }
        }
    }
}
