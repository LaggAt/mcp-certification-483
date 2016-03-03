using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAndTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            Debug.Assert(n < 3, "Alert from Debug.Assert : n < 3");
            Debug.WriteLine("Executing Debug.WriteLine..");

            Trace.Assert(n < 4, "Alert from Trace.Assert : n < 4");
            Trace.WriteLine("Executing Trace.WriteLine..");

            Console.ReadLine();
        }
    }
}
