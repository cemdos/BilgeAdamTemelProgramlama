using BankaUygulamasi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Controller
{
    public class KullaniciIslemleri
    {
        public static Kullanici AktifKullanici { get; private set; }
        public static Kullanici GirisYap(string TC, string Sifre)
        {
            var aktifKullanici = Database.Database.Kullanicilar.Find(x => x.Tc == TC && x.Sifre == Sifre);
            AktifKullanici = aktifKullanici;
            return aktifKullanici;
        }
    }
}
