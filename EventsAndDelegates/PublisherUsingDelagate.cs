using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class PublisherUsingDelagate
    {
        public delegate string ShowDelegate(int i, bool b);

        public ShowDelegate ShowDelegateEvent;

        public void PublishMessage()
        {
            if (ShowDelegateEvent != null)
            {
                var length = ShowDelegateEvent.GetInvocationList().Length;
                ShowDelegateEvent.Invoke(length, true);
            }
        }
    }
}
