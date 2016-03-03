using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOutAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            // uses Value Type
            Method(n);
            Console.WriteLine("n : " + n);

            // uses Reference Type
            MethodWithOut(out n);
            Console.WriteLine("n : " + n);

            // uses Reference Type
            MethodWithRef(ref n);
            Console.WriteLine("n : " + n);

            Person person = new Person
            {
                Fullname = "Mohamed"
            };
            // uses Reference Type
            MethodPerson(person);
            Console.WriteLine("person.Fullname : " + person.Fullname); // "Ahmed"

            string str = "123";
            int i = 0;
            int.TryParse(str, out i); // i = 123
        }

        private static void MethodPerson(Person person)
        {
            person.Fullname = "Ahmed";
        }

        private static void Method(int i)
        {
            i = 9;
        }

        private static void MethodWithOut(out int i)
        {
            i = 7;
        }

        private static void MethodWithRef(ref int i)
        {
            i = 11;
        }
    }
}
