using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UsingAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = DownloadContentAsync().Result;
            Console.WriteLine(result);
        }
        public static async Task<string> DownloadContentAsync()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(
                "http://taskmodel.azurewebsites.net/api/TaskModels/");

            return result;
        }
    }
}
