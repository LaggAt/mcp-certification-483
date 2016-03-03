using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class MathOperations
    {
        public double Divide(int a, int b)
        {
            double r = 0;
            try
            {
                r = a/b;
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("DivideByZeroException raised inside Divide() : " + divideByZeroException.Message);

                // throw;
                // throw divideByZeroException;
                throw new CustomException
                {
                    Error = "CustomException raised.."
                };
            }
            catch (ArithmeticException arithmeticException)
            {
                Console.WriteLine("ArithmeticException raised Inside Divide() : " + arithmeticException.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception raised Inside Divide() : " + exception.Message);
            }
            finally
            {
                Console.WriteLine("Inside finally block..");
            }
            int v = 3; // will not be executed when exception thrown
            return r;
        }
    }
}
