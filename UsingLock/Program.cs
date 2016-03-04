using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLock
{
    class Program
    {

        private static object obj = new object();

        static void Main(string[] args)
        {

            lock (obj)
            {
                
            }
        }
    }
}
