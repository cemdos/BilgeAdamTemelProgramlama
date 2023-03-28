using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public class Ilce
    {
        public int SehirKodu { get; set; }
        public string Ilceadi { get; set; }

        public Ilce(int SehirKodu, string IlceAdi)
        {
            this.SehirKodu = SehirKodu;
            this.Ilceadi = IlceAdi;
        }
    }
}
