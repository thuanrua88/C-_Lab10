using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper1
{
    class InvalidCastError
    {
        static void Main(string[] args)
        {
            try
            {
                float numOne = 3.14f;
                object obj = numOne;
                int result = (int)obj;
                Console.WriteLine("Value of numone= {0}", result);
            }
            catch(InvalidCastException e) {
                Console.WriteLine("Error: {0}", e);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
