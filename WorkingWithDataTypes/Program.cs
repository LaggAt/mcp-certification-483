using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple types in C#
            string str = ""; // alias to String
            String str2 = ""; // object String

            bool b = true;
            Boolean b2 = false;

            short s = 4354; // alias to Int16
            Int16 i16 = 4545; // short
            int n = 5; // alias to Int32
            Int32 i32 = 456546487; // int
            long l = 46564864; // alias to Int64
            Int64 i64 = 1335464646464684786; // long

            float f = 5.148f;
            double d = 8.458;
            char c = 'c';

            int[] tab = new int[3];
            int[] tab2 = new int[] { 5, 7, 9 };

            for (int i = 0; i < tab2.Length; i++)
            {
                Console.WriteLine("tab2[i] : " + tab2[i]);
            }

            foreach (int i in tab2)
            {
                Console.WriteLine("i : " + i);
            }

            List<int> list = new List<int>();
            list.Add(5);
            list.Add(7);
            list.Add(9);

            List<int> list2 = new List<int>()
            {
                5, 7, 9, 11,
            };
            list.Add(13);
            list.Remove(13);

            MyList<string> myList = new MyList<string>();
            myList.AddTwoMembers("Mohamed", "Ali");

            foreach (var item in myList)
            {
                Console.WriteLine("myList : " + item);
            }

            // using var keyword
            var x = 5;
            var myList2 = new MyList<string>();

            // using dynamic keyword
            dynamic dynammicType = 5;
            Console.WriteLine("dynammicType : " + dynammicType);
            dynammicType = "str";
            dynammicType = new
            {
                Length = 5,
                Width = 10,
            };
            Console.WriteLine("dyn.Length : " + dynammicType.Length);
            Console.WriteLine("dyn.Width : " + dynammicType.Width);

            Console.ReadLine();
        }
    }
}
