using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAndRelease
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.WriteLine("In DEBUG mode..");
            MethodWithConditionalCompilationSymbol();
#else
            Console.WriteLine("Not in DEBUG mode, may be in RELEASE mode or any other..");
#endif

#if RELEASE
            Console.WriteLine("In RELEASE mode..");
            Console.WriteLine("RELEASE is already defined under Project -> Properties -> Build");
#endif

#if TEST
            Console.WriteLine("In TEST mode..");
#endif
            MethodWithConditionalDebug();

            Person person = new Person
            {
                Fullname = "Mohamed",
                Age = 25
            };

            Console.ReadLine();
        }

        /// <summary>
        /// This method will be called only on Debug mode,
        /// as specified by the attribute : [Conditional("DEBUG")]
        /// </summary>
        [Conditional("DEBUG")]
        private static void MethodWithConditionalDebug()
        {
            Console.WriteLine("Inside MethodWithConditionalDebug()..");
        }

        /// <summary>
        /// This method will be called only on Debug mode,
        /// as it is inside : #if DEBUG
        /// </summary>
        private static void MethodWithConditionalCompilationSymbol()
        {
            Console.WriteLine("Inside MethodWithConditionalCompilationSymbol()..");
        }
    }
}
