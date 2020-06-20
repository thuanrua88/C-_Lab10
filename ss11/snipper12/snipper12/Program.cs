using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "James" };
            int numOne = 0;
            int result;
            try
            {
                Console.WriteLine("This is the outer try block");
                try
                {
                    result = 133 / numOne;
                }
                catch (ArithmeticException objMaths)
                {
                    Console.WriteLine("Divide by 0 " + objMaths);
                }
                names[2] = "Smith";
            }
            catch (IndexOutOfRangeException objIndex)
            {
                Console.WriteLine("Wrong number of arguments supplied " + objIndex);
            }


        }

    }
}
