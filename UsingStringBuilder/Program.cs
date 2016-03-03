using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "";
            s += "Home";

            StringBuilder sb = new StringBuilder();
            sb.Append("Home");
            sb.Append("House");

            Console.WriteLine("sb : " + sb); //HomeHouse

            string str1 = "Values : " + 5 + "," + 7;
            string str = string.Format("Values : {0}, {1}", 5, 7);

            Console.WriteLine("str : " + str); // Values : 5, 7

            Console.WriteLine();
        }
    }
}
