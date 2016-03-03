using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndEventHandlers
{
    class CustomEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
