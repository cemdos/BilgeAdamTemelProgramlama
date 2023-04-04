using SinemaBiletOtomasyonu.Exceptions;
using SinemaBiletOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Business
{
    public class MusteriIsLemleri
    {
        public Musteri aktifMusteri { get;}
        public MusteriIsLemleri(Kullanici kullanici)
        {
            //aktifMusteri = Database.Instance.Musteriler.Find(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre);
            aktifMusteri = Database.Instance.Musteriler.Find(x => x == (Musteri)kullanici);
            if (aktifMusteri == null)
                throw new MusteriBulunamadiException();
        }
    }
}
