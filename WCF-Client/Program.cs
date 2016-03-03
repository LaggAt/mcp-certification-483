using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Client.WCFServiceReference;

namespace WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client service1Client = new Service1Client();

            Console.WriteLine("Calling web service..");

            string result = service1Client.GetData(584);

            Console.WriteLine("result : " + result);

            Console.ReadLine();
        }
    }
}
