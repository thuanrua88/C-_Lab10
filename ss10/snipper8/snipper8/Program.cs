using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper8
{
    namespace Automotive
    {

        class Toyota
        {
            static void Main(string[] args)
            {
                Category obj = new Category();
                SpareParts objSpare = new SpareParts();
                obj.Display(); objSpare.Display();
            }
        }
    }
    
}
