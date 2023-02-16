using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimKutuphanem
{
    public class Matematik
    {
        public static double FaktoriyelAl(int sayi)
        {
            var carpim = 1;
            for (int i = 2; i <= sayi; i++)
            {
                carpim *= i;
            }
            return carpim;
        }
    }
}
