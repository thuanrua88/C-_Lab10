using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category
            {
                string _category;
                public Category()
                {
                    _category = “Multi Utility Vehicle”;
                }
                public void Display()
                {
                    Console.WriteLine(“Jeep Category: “ +_category);
                }
            }
        }
        class Automobile
        {
            static void Main(string[] args)
            {
                Category objCat = new Category();
                objCat.Display();
                Utility_Vehicle::Category objCategory = new Utility_Vehicle::
                Category();
                objCategory.Display();
            }
        }
    }
}
