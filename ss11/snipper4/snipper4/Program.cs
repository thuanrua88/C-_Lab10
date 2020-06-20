using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper4
{
    class ExceptionMethods
    {
        static void Main(string[] args)
        {
            byte numOne = 200;
            byte numTwo = 5;
            byte result = 0;
            try
            {
                result = checked((byte)(numOne * numTwo));
                Console.WriteLine(result);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetType());
            }
            Console.Read();
        }
    }
}
