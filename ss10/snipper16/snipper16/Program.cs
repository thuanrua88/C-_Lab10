using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Companies
{
    extern alias LibaryOne;
    extern alias LibaryTwo;
    using System;

    class Companies
    {
        static void Main(string[] args)
        {
            LibaryOne::Employees.Display();
            LibraryTwo::Employees.Display();
        }
    }
}
