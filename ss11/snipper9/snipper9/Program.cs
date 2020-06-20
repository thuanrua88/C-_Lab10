using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            try
            {
                result = numOne / numTwo;
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception caught: " +objDivide);
            }
            finally
            {
                Console.WriteLine("This finally block will always be executed");
            }
            Console.Read();
        }
    }
}
