using SinemaBiletOtomasyonu.Exceptions;
using SinemaBiletOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Business
{
    public class KullaniciIsLemleri
    {
        public Kullanici Login(string kullaniciAdi, string Sifre)
        {
            var arananKullanici = Database.Instance.Kullanicilar.Find(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == Sifre);
            if (arananKullanici == null)
                throw new KullaniciBulunamadiException();
            return arananKullanici;
        }
    }
}
