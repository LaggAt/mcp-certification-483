using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace UsingGarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {

            // The finalizer is called only when a garbage collection occurs. 
            // You can force this by adding a call to GC.Collect
            // WaitForPendingFinalizers makes sure that all finalizers have run before the code continues.
            // The garbage collector is pretty smart in managing memory, and it’s not recommended that you call GC.Collect yourself.

            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //GC.KeepAlive(this);
        }
    }
}
