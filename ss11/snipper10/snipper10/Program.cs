using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System {
    class NumberDoer
    {
        public void Process(int numOne, int numTwo)
        {
            try
            {
                if (numTwo == 0)
                {
                    throw new DivideByZeroException("Value of divisor is zero");
                }
                else
                {
                    Console.WriteLine("Quotient: " + (numOne / numTwo));
                    Console.WriteLine("Remainder: " + (numOne % numTwo));
                }
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Error: " + objDivide);
            }

        }
        class NumberTester {
            NumberDoer objDoer = new NumberDoer();
            public void AcceptDetails()
            {
                int dividend = 0;
                int divisor = 0;
                Console.WriteLine("Enter the value of dividend");
                try
                {
                    dividend = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException objForm)
                {
                    Console.WriteLine("Error: " +objForm);
                }
                Console.WriteLine("Enter the value of divisor");
                try
                {
                    divisor = Convert.ToInt32(Console.ReadLine());
                        }
                catch (FormatException objFormat)
                {
                    Console.WriteLine("Error: " +objFormat);
                }
                if ((dividend > 0) || (divisor > 0))
                {
                    objDoer.Process(dividend, divisor);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            } 
    
        static void Main(string[] args)
            {
                NumberTester objTester = new NumberTester();
                objTester.AcceptDetails();
            }
        }
    }
}


