using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAndRelease
{
    [DebuggerDisplay("Fullname = {Fullname}, Age = {Age}")]
    class Person
    {

        public string Fullname { get; set; }

        public int Age { get; set; }
    }
}
