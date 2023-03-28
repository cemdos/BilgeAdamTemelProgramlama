using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public class Musteri : Kullanici
    {
        public List<Hesap> Hesaplar { get; set; }
        public string YasadigiSehir { get; set; }
        public string YasadigiIlce { get; set; }
    }
}
