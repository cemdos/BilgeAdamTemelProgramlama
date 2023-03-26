using BankaUygulamasi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Controller
{
    public class MusteriIslemleri
    {
        public Musteri AktifMusteri { get; private set; }

        public MusteriIslemleri(Kullanici kullanici)
        {
            AktifMusteri = Database.Database.Musteriler.Find(x => x.Tc == kullanici.Tc);
        }
    }
}
