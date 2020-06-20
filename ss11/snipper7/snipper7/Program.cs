using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper7
{
    class Students
    {
        string[] names = {"James", "John", "Alexander"};
        static void Main(string[] args)
        {
            Students objStudents = new Students();
            try
            {
                objStudents.names[4] = "John";
            }
            catch (Exception objException)
            {
                Console.WriteLine("Error: " +objException);
            }
            Console.Read();
        }
    }
}
