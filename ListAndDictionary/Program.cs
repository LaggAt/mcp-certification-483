using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] array =
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {42,21}
            };

            var dictionary = new Dictionary<string, int>();
            dictionary.Add("n1", 584321);
            dictionary.Add("n2", 158478);
            dictionary.Add("n3", 458885);

            var dictionary2 = new Dictionary<string, int>
            {
                {"n1", 45864 },
                {"n2", 15486 },
                {"n3", 95842 },
            };

            Console.WriteLine("dictionary[\"n1\"] : " + dictionary["n1"]);

            // Queue implements FIFO (First In First Out)
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Dequeue();

            // Stack implements LIFO (Last In First Out)
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Pop();

            // A set is a collection that contains no duplicate elements and has no particular order
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("home");
            hashSet.Add("house");
            hashSet.Remove("home");

            Console.ReadLine();
        }
    }
}
