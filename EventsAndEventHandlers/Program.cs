using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndEventHandlers
{
    class Program
    {
        static void Main(string[] args)
        {

            Publisher publisher = new Publisher();
            publisher.ShowEventHandler += (object sender, EventArgs e) =>
            {
                string s = string.Format("sender : {0}, e : {1}", sender, e);
                Console.WriteLine(s);
            };

            // no outside users can raise your event. 
            // It can be raised only by code that’s part of the class 
            // that defined the event.
            //publisher.ShowEventHandler.Invoke("message", new EventArgs());
            publisher.RaiseEvent();

            publisher.ShowEventHandlerWithCustomEventArgs += (object sender, CustomEventArgs e) =>
            {
                string s = string.Format("sender : {0}, e.Message : {1}", sender, e.Message);
                Console.WriteLine(s);
            };
            publisher.RaiseEventWithCustomEventArgs();

            Console.ReadLine();
        }
    }
}
