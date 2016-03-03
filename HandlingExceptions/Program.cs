using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            MathOperations mathOperations = new MathOperations();
            try
            {
                double r = mathOperations.Divide(5, 0);
                Console.WriteLine("r : " + r);
            }
            catch (CustomException customException)
            {
                Console.WriteLine("customException.Error : " + customException.Error);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception catched inside Main()");
            }

            Console.ReadLine();
        }
    }
}
