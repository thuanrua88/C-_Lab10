using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "name", "jack", "perter" };
            int[] id = { 11, 12, 13 };
            double[] salary = { 1000, 2000, 3000 };
            float[] bonus = new float[3];
            try
            {
                salary.CopyTo(bonus, 0);
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
