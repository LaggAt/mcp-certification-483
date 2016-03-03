using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataTypes
{
    /// <summary>
    /// Showing Generic Types.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyList<T> : List<T> where T : class 
    {
        public void AddTwoMembers(T a, T b)
        {
            Add(a);
            Add(b);
        }
    }
}
