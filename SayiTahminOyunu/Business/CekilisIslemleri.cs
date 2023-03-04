using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.Business
{
    public class CekilisIslemleri
    {
        public static byte[] RastgeleSayiUret(Random rnd)
        {
            byte[] sayiListesi = new byte[6];
            for (int i = 0; i < 6; i++)
            {
                byte rastSayi = (byte)rnd.Next(1, 50);
                //bool dizideVarmi = sayiListesi.Contains(rastSayi);
                bool dizideVarmi = Array.IndexOf(sayiListesi, rastSayi) > -1;
                if (dizideVarmi) {
                    i--;
                    continue;
                }

                sayiListesi[i] = rastSayi;
            }
            Array.Sort(sayiListesi);
            return sayiListesi;
        }

        public static object[] KuponUret(int kuponAdedi)
        {
            Random rnd = new Random();
            object[] kuponlar = new object[kuponAdedi];
            for (int i = 0; i < kuponAdedi; i++)
                kuponlar[i] = RastgeleSayiUret(rnd); 
            return kuponlar;
        }

        public static string KuponYaz(byte[] kupon)
        {
            string data = string.Empty;
            for (int i = 0; i < kupon.Length; i++)
                data += kupon[i].ToString().PadLeft(2, '0') + " ";
            return data;
        }
    }
}
