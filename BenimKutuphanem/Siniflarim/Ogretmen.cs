using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimKutuphanem.Siniflarim
{
    public class Ogretmen:Ogrenci
    {
        public string Brans { get; set; }
        public Ogretmen()
        {
            Brans = "Tanımsız";
        }
    }
}
