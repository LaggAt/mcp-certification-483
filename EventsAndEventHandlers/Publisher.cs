using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndEventHandlers
{
    class Publisher
    {

        /// <summary>
        /// An event cannot be directly assigned to 
        /// (with the = instead of +=) operator. 
        /// So you don’t have the risk of someone removing 
        /// all previous subscriptions, as with the delegate syntax.
        /// Another change is that no outside users can raise your event. 
        /// It can be raised only by code that’s part of the class 
        /// that defined the event.
        /// </summary>
        public event EventHandler ShowEventHandler;

        public event EventHandler<CustomEventArgs> ShowEventHandlerWithCustomEventArgs;

        public void RaiseEvent()
        {
            if (ShowEventHandler != null)
            {
                ShowEventHandler.Invoke("message", new EventArgs());
            }
        }

        public void RaiseEventWithCustomEventArgs()
        {
            if (ShowEventHandlerWithCustomEventArgs != null)
            {
                
                CustomEventArgs customEventArgs = new CustomEventArgs
                {
                    Message = "New Email.."
                };
                ShowEventHandlerWithCustomEventArgs.Invoke("message", customEventArgs);
            }
        }
    }
}
