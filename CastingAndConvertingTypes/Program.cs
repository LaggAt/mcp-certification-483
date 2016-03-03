using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingAndConvertingTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "123";

            //int i = (int) s; // compilation error

            // conversion using Parse
            int i = int.Parse(s); // raises an exception when conversion failed
            Console.WriteLine("i : " + i);

            int n = 0;
            bool isSucceeded = int.TryParse(s, out n); // doesn't raise  an exception when failing conversion

            Console.WriteLine("isSucceeded : " + isSucceeded);
            Console.WriteLine("n : " + n);

            // conversion using Convert class
            int i32 = Convert.ToInt32(s);
            Console.WriteLine("i32 : " + i32);

            // Conversion using casting
            Person person = new Person
            {
                Name = "Mohamed"
            };
            Object obj = person;
            Person p = (Person) obj; // raises an exception when casting failes
            Console.WriteLine("p.Name : " + p.Name);

            // conversion using 'as'
            Person p2 = obj as Person; // 'as' doesn't raise an exception when casting failes
            Console.WriteLine("p2.Name : " + p2.Name);

            // using 'is' keyword
            var type = obj.GetType();
            if (type == typeof(Person))
            {
                // obj is of type Person
            }

            bool isObjOfTypePerson = obj is Person;
            if (isObjOfTypePerson)
            {
                // obj is of type Person
                Person p3 = (Person) obj;
                Console.WriteLine("p3.Name : " + p3.Name);
            }

            Console.ReadLine();
        }
    }
}
