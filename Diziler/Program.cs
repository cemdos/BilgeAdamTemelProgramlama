using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Örnek - Sınıf mevcudu Klavyeden girilip tüm ögrencilerin sınıf ortalamasının üzerinde mi altındamı oldugunu gösteren kod 

            byte sinifMevcudu;
            int toplam = 0, ortalama;
            Console.Write("Sınıf Mevcudu = ");
            sinifMevcudu = byte.Parse(Console.ReadLine());
            byte[] notlar = new byte[sinifMevcudu];
            for (int i = 0; i < notlar.Length; i++)
            {
                Console.Write("{0}. Öğrencinin notu = ", i + 1);
                notlar[i] = byte.Parse(Console.ReadLine());
                toplam += notlar[i];
            }
            ortalama = toplam / sinifMevcudu;
            for (int i = 0; i < notlar.Length; i++)
            {
                string durum = notlar[i] > ortalama ? "üstündedir." : "altındadır.";
                Console.WriteLine("{0}. Öğrenci sınıf ortalamasının {1}", i + 1, durum);
            }


            #endregion


        }
    }
}
