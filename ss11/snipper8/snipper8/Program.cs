using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper8
{
    class Program
    {
        static void ThrowException(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Throw Example");
            try
            {
                string empName = null;
                ThrowException(empName);
            }
            catch (ArgumentNullException objNull)
            {
                Console.WriteLine("Exception caught: " + objNull);
            }
            Console.Read();
        }
    }
}
