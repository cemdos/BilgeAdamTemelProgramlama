using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public class Sehir
    {
        public int SehirKodu { get; set; }
        public string SehirAdi { get; set; }

        public Sehir(int SehirKodu, string SehirAdi)
        {
            this.SehirKodu = SehirKodu;
            this.SehirAdi = SehirAdi;
        }
    }
}
