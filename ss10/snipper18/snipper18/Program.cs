using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility_Vehicle
{
    namespace Car
    {
        class Category
        {
            string category;
            public Category()
            {
                category = "Luxx";
            }
            public void Display()
            {
                Console.WriteLine("Category: " + category);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
