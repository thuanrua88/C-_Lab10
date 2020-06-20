using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper3
{
    class Employee
    {
        private string empName;
        private int empID;
        public void Employe()
        {
            empID = 101;
            empName = "dn";
        }
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            Employee objEm = obj;
            obj = null;
            try
            {
                Console.WriteLine(obj.empName);
                Console.WriteLine(obj.empName);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
