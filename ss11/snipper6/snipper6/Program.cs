using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 133;
            int numTwo = 09;
            int result;
            try
            {
                result = numOne / numTwo;
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception caught: " +objDivide);
            }
            Console.Read();
        }
    }
}
