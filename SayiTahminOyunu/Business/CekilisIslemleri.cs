using SayiTahminOyunu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.Business
{
    public class CekilisIslemleri
    {
        private static byte[] RastgeleSayiUret(Random rnd)
        {
            byte[] sayiListesi = new byte[6];
            for (int i = 0; i < 6; i++)
            {
                byte rastSayi = (byte)rnd.Next(1, 50);
                //bool dizideVarmi = sayiListesi.Contains(rastSayi);
                bool dizideVarmi = Array.IndexOf(sayiListesi, rastSayi) > -1;
                if (dizideVarmi)
                {
                    i--;
                    continue;
                }

                sayiListesi[i] = rastSayi;
            }
            Array.Sort(sayiListesi);
            return sayiListesi;
        }

        public static List<Kupon> KuponUret(int kuponAdedi)
        {
            Random rnd = new Random();
            List<Kupon> kuponlar = new List<Kupon>();
            kuponAdedi = kuponAdedi == 1 ? 1 : (kuponAdedi - 1);
            for (int i = 0; i < kuponAdedi; i++)
            {
                Kupon yeniKupon = new Kupon();
                yeniKupon.Veriler = RastgeleSayiUret(rnd);
                kuponlar.Add(yeniKupon);
            }

            return kuponlar;
        }

        public static int[] CekilisSonucuHesapla(List<Kupon> kuponListesi, Kupon cekilisSonucu)
        {
            int[] bilenler = new int[7];
            foreach (Kupon kupon in kuponListesi)
            {
                int sayac = 0;
                foreach (byte item in cekilisSonucu.Veriler)
                {
                    bool kupondaVarmi = kupon.Veriler.Contains(item);
                    if (kupondaVarmi)
                        sayac++;
                }
                kupon.KacBildi = (byte)sayac;
                bilenler[sayac]++;
            }
            return bilenler;
        }
    }
}
