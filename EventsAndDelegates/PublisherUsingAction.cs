using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class PublisherUsingAction  
    {

        public Action ShowAction { get; set; }

        public Action<string> ShowActionWithParam { get; set; }

        public void PublishMessage(string message)
        {
            ShowAction.Invoke();
            ShowActionWithParam.Invoke(message);
        }
    }
}
