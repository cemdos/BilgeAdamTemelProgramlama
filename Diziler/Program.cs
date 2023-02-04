using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

            //byte sinifMevcudu;
            //int toplam = 0, ortalama;
            //Console.Write("Sınıf Mevcudu = ");
            //sinifMevcudu = byte.Parse(Console.ReadLine());
            //byte[] notlar = new byte[sinifMevcudu];
            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    Console.Write("{0}. Öğrencinin notu = ", i + 1);
            //    notlar[i] = byte.Parse(Console.ReadLine());
            //    toplam += notlar[i];
            //}
            //ortalama = toplam / sinifMevcudu;
            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    string durum = notlar[i] > ortalama ? "üstündedir." : "altındadır.";
            //    Console.WriteLine("{0}. Öğrenci sınıf ortalamasının {1}", i + 1, durum);
            //}


            #endregion

            #region 2. Sayısal Loto Sıralı olacak
            //Random rnd = new Random();
            //byte[] sayilar = new byte[6];
            //byte[] sayilar2 = new byte[6];

            //for (char harf = 'A'; harf <= 'G'; harf++) // Kolonlar icin
            //{
            //    Console.Write("{0}: ", harf);
            //    for (int i = 0; i < sayilar.Length; i++) //Rastgele üretilen sayılar icin
            //    {
            //        byte sayi = (byte)rnd.Next(1, 50);
            //        if (!sayilar.Contains(sayi))
            //            sayilar[i] = sayi;
            //        else
            //            i--;
            //    }
            //    Array.Copy(sayilar, sayilar2, 0);
            //    Array.Sort(sayilar2);
            //    Array.Reverse(sayilar2);
            //    foreach (byte item in sayilar)
            //        Console.Write(item.ToString().PadLeft(2, '0') + " ");
            //    Console.WriteLine();
            //}
            #endregion

            #region 3. Örnek - Continue Deyimi örneği

            //while (true)
            //{
            //    int sayi;
            //    Console.Write("Sayı Giriniz");
            //    bool cevirdimi = int.TryParse(Console.ReadLine(), out sayi);
            //    if (!cevirdimi)
            //        continue;

            //    decimal carpim = 1;
            //    for (int i = sayi; i > 1; i--)
            //        carpim *= i;

            //    Console.WriteLine("Sonuc = " + carpim);
            //    break;
            //}

            #endregion

            ArrayList sayilar = new ArrayList();
            //Evde yaptığım geliştirme
            //İş yerinde bu kodu yazdım 
        }
    }
}
