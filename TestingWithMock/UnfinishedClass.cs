using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWithMock
{
    public class UnfinishedClass
    {

        public virtual int PropReturning6
        {
            get
            {
                return 6;
            }
        }
        
        public virtual int UnfinishedMethod(int val)
        {
            // implementation would later return val * 2, except for 2, returning 2. But:
            throw new NotImplementedException();
        }

    }
}
