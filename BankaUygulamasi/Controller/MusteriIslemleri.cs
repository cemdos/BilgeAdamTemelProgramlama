using BankaUygulamasi.Enum;
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

        public int MyProperty { get; set; }

        public MusteriIslemleri(Kullanici kullanici)
        {
            AktifMusteri = Database.Database.Musteriler.Find(x => x.Tc == kullanici.Tc);
        }

        public (Musteri gonderilecekMusteri, bool MusteriVarmi) MusteriAra(string HesapNo)
        {
            foreach (var item in Database.Database.Musteriler)
            {
                var hesap = item.Hesaplar.Find(x => x.HesapNo.ToString() == HesapNo);
                if (hesap != null)
                    return (item, true);
            }
            return (null, false);
        }

        public bool MusterideHesapTanimliMi(HesapTipi hesapTipi)
        {
            var donenHesap = AktifMusteri.Hesaplar.Find(x => x.HesapTipi == hesapTipi);
            return donenHesap != null;
        }
    }
}
