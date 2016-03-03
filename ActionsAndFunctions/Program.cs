using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Action with Lambda Expression
            Action action = () =>
            {
                Console.WriteLine("Inside Action Implementation..");
            };
            action.Invoke();
            action();

            // Action with parameter
            Action<int> actionInt = (int a) =>
            {
                Console.WriteLine("actionInt, a : " + a);
            };
            actionInt.Invoke(7);
            actionInt(9);

            // Action that points to a method
            Action action2 = Method;
            action2.Invoke();

            // Using Func
            Func<int, bool, string> func = (int x, bool b) =>
            {
                Console.WriteLine("Inside Func<int, bool, string>..");
                return "func";
            };
            var r = func.Invoke(5, true);
            func(5, true);

            // Func with method
            Func<int, bool, string> func2 = MethodForFunc;
            func2.Invoke(9, false);

            Console.WriteLine("r : " + r);

            Console.ReadLine();
        }

        private static string MethodForFunc(int i, bool b)
        {
            Console.WriteLine(i + b.ToString());
            return "Hello";
        }

        static void Method()
        {
            Console.WriteLine("Inside Method()..");
        }
    }
}
