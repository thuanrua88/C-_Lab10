using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper14
{
    class TypeInitError
    {
        static TypeInitError()
        {
            throw new ApplicationException(" This program throws TypeInitializationException error.");
        }
        static void Main(string[] args)
        {
            try
            {
                TypeInitError objType = new TypeInitError();
            }
            catch (TypeInitializationException objEx)
            {
                Console.WriteLine("Error: {0}",objEx);
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error: {0}", objEx);
            }
        }
    }

        }
