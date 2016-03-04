using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject
{
    public class Class1
    {

        public string Message { get; set; }

        public Class1()
        {
            Message = "Message from Object Class1 located in a another class library";
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
