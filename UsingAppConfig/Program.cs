using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAppConfig
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

            Console.WriteLine(connectionString);

            Console.ReadLine();
        }
    }
}
