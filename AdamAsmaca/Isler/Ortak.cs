using AdamAsmaca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca.Isler
{
    public class Ortak
    {
		private static List<Kullanici> kullanicilar;

		public static List<Kullanici> Kullanicilar
        {
			get {
                if (kullanicilar == null)
                {
                    kullanicilar = new List<Kullanici>();
                    kullanicilar.Add(new Kullanici
                    {
                        KullaniciAdi = "cemdos",
                        Sifre = "1234"
                    });
                    kullanicilar.Add(new Kullanici
                    {
                        KullaniciAdi = "tuba",
                        Sifre = "1234"
                    });
                }
                return kullanicilar;
            }
		}

        public static Kullanici AktifKullanici { get; set; }
    }
}
