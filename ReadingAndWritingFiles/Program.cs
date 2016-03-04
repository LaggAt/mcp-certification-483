using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWritingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/mytestfile.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            string s = File.ReadAllText(path);
            Console.WriteLine(s);

            CreateAndWriteAsyncToFile();

            Console.ReadLine();
        }

        public static async Task CreateAndWriteAsyncToFile()
        {
            using (FileStream stream = new FileStream(
                "test.dat",
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                4096,
                true))
            {
                byte[] data = new byte[100000];
                new Random().NextBytes(data);
                await stream.WriteAsync(data, 0, data.Length);
            }
        }
    }
}
