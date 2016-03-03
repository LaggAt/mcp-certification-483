using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implementing Publish/Subscribe with Action
            PublisherUsingAction calculator = new PublisherUsingAction();
            calculator.ShowAction = () =>
            {
                Console.WriteLine("Executing ShowAction..");
            };
            calculator.ShowAction += () =>
            {
                Console.WriteLine("Executing ShowAction.. 2..");
            };

            // adding a parameter
            calculator.ShowActionWithParam = (string s) =>
            {
                Console.WriteLine("Message received s = " + s);
            };
            calculator.ShowActionWithParam += (string s) =>
            {
                Console.WriteLine("Message received # 2 , s = " + s);
            };
            calculator.PublishMessage("New Email");

            // using PublisherUsingDelagate
            var publisher = new PublisherUsingDelagate();
            publisher.ShowDelegateEvent = (int i, bool b) =>
            {
                var s = string.Format("i : {0}, b : {1}", i, b.ToString());
                Console.WriteLine("publisher.ShowDelegateEvent, s : " + s);
                return s;
            };
            publisher.PublishMessage();

            Console.ReadLine();
        }
    }
}
