using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimKutuphanem.Siniflarim
{
    public class Ogrenci : Insan
    {
        public List<string> AldigiDersler { get; protected set; }
        public string OgrenciNo { get; protected set; }

        public Ogrenci()
        {
            AldigiDersler = new List<string>();
            OgrenciNo = string.Empty;
        }

        public Ogrenci(string OgrenciNo, int Yas, int Boy):base(Yas, Boy)
        {
            AldigiDersler = new List<string>();
            this.OgrenciNo = OgrenciNo;
        }
    }
}
