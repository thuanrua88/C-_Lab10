using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper15
{
    public class CustomMessage : Exception
    {
        public CustomMessage(string message) : base(message)
        {
        }
    }
    public class CustomException
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomMessage("This illustrates creation and catching of custom exception");
            }
            catch (CustomMessage objCustom)
            {
                Console.WriteLine(objCustom.Message);
            }
        }
    }
}
