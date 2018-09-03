using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            UseAsync();
            UseWaitHandle();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }

        static void UseAsync() { 
            // await inside here waits for the result
            Task<string> task = DownloadContent();
            Console.WriteLine($"Got {task.Result.Length} bytes from request");
        }
        
        // same without using async/await
        static void UseWaitHandle()
        {
            ManualResetEvent mResetEv = new ManualResetEvent(false);
            Task<string> task = DownloadContentAsync();
            task.Wait(100); // just wait some milliseconds, maybe we get a timeout
            if (task.IsCompleted)
            {
                Console.WriteLine($"Got {task.Result.Length} bytes from request");
            }
        }

        public static async Task<string> DownloadContent()
        {
            var result = await DownloadContentAsync();
            return result;
        }
        public static Task<string> DownloadContentAsync()
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            Task<string> task = client.GetStringAsync("https://github.com/LaggAt/mcp-certification-483/");
            return task;
        }
    }
}
