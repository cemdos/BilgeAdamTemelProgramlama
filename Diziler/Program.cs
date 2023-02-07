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

            #region 4. Örnek - Klavyeden girilen tüm degerleri 0'a basana kadar dizi icerisine atan prog.

            //ArrayList dizi = new ArrayList();
            //string veri;
            //do
            //{
            //    Console.Write("Veri Giriniz = ");
            //    veri = Console.ReadLine();
            //    dizi.Add(veri);
            //} while (veri != "0");

            //Console.WriteLine("Diziye atılan veriler");
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5.Örnek - Rastgele üretilen 20 sayıdan tek olanlar tek diziye cift olanları cift diziye aktaran prg
            //ArrayList tekSayilar = new ArrayList();
            //ArrayList ciftSayilar = new ArrayList();
            //Random rnd = new Random();

            //for (int i = 0; i < 20; i++)
            //{
            //    int sayi = rnd.Next(0,50);
            //    if (sayi % 2 == 0) // Cifttir
            //        ciftSayilar.Add(sayi);
            //    else
            //        tekSayilar.Add(sayi);
            //}

            //Console.WriteLine("Tek Sayılar");
            //foreach (var item in tekSayilar)
            //    Console.WriteLine(item);
            //Console.WriteLine("Cift Sayılar");
            //foreach (var item in ciftSayilar)
            //    Console.WriteLine(item);
            //Console.WriteLine("Cift Dizisinin 2 elemanı = " + ciftSayilar[1]);

            #endregion

            #region 6. Örnek - Stack Mantıgı
            //Stack yigin = new Stack();
            //yigin.Push("1");
            //yigin.Push("2");
            //yigin.Push("3");
            //int elamanSayisi = yigin.Count;

            //for (int i = 0; i < elamanSayisi; i++)
            //{
            //    Console.WriteLine(yigin.Pop());
            //}
            #endregion

            #region 7. Örnek Queue Mantıgı
            //Queue<string> kuyruk = new Queue<string>();
            //kuyruk.Enqueue("ali");
            //kuyruk.Enqueue("veli");
            //kuyruk.Enqueue("ahmet");
            //kuyruk.Enqueue("ayşe");

            //Console.WriteLine(kuyruk.Dequeue());
            //Console.WriteLine(kuyruk.Dequeue());
            //Console.WriteLine(kuyruk.Dequeue());
            //Console.WriteLine(kuyruk.Dequeue());
            //Console.WriteLine(kuyruk.Dequeue()); // Burayı calıstırmaz cünkü kuyruk bosaldı
            #endregion

            #region 8. Örnek - LIST mantığı
            //List<int> sayilar = new List<int>();
            //sayilar.Add(25);
            //sayilar.Add(50);
            //sayilar.Add(60);

            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            #endregion

            #region 9.Örnek - Object ifadelerin aritmetiksel ve karsılastırma islemlerinde kullanımı
            //ArrayList dizi = new ArrayList();
            //dizi.Add(Console.ReadLine());
            //dizi.Add(Console.ReadLine());
            ////Burada nereye düser incelenmeli ?
            //if (dizi[0] == dizi[1])
            //    Console.WriteLine("Esittir");
            //else
            //    Console.WriteLine("Esit Degildir");
            #endregion

            #region 10. ÖRnek - SortedList Mantıgı
            //SortedList TRSozluk = new SortedList();
            //SortedList ENSozluk = new SortedList();
            //SortedList seciliSozluk = new SortedList();

            //TRSozluk.Add("headerText", "Hoşgeldiniz");
            //TRSozluk.Add("Text2", "muz");
            //TRSozluk.Add("Text1", "elma");


            //ENSozluk.Add("headerText", "Welcome");
            //ENSozluk.Add("Text2", "Banana");
            //ENSozluk.Add("Text1", "Apple");


            //Console.Write("Dil Seçiniz (en/tr):");
            //string dil = Console.ReadLine();
            //switch (dil.ToUpper())
            //{
            //    case "TR": seciliSozluk = TRSozluk; break;
            //    case "EN": seciliSozluk = ENSozluk; break;
            //}

            //Console.WriteLine(seciliSozluk["headerText"]);


            #endregion

            #region 11. Örnek - Dictionary Mantığı
            //var TRSozluk = new Dictionary<string,string>();
            //var ENSozluk = new Dictionary<string, string>();
            //var seciliSozluk = new Dictionary<string, string>();

            //TRSozluk.Add("headerText", "Hoşgeldiniz");
            //TRSozluk.Add("Text2", "muz");
            //TRSozluk.Add("Text1", "elma");


            //ENSozluk.Add("headerText", "Welcome");
            //ENSozluk.Add("Text2", "Banana");
            //ENSozluk.Add("Text1", "Apple");


            //Console.Write("Dil Seçiniz (en/tr):");
            //string dil = Console.ReadLine();
            //switch (dil.ToUpper())
            //{
            //    case "TR": seciliSozluk = TRSozluk; break;
            //    case "EN": seciliSozluk = ENSozluk; break;
            //}

            //Console.WriteLine(seciliSozluk["headerText"]);
            #endregion

            #region 12. Örnek - 3 Boyutlu Dizi
            //string[,,] veriler = { // 1. Boyut
            //                      { //2. Boyut
            //                        {"45","60" },{"45","60" }//3. Boyut
            //                      },
            //                      {
            //                        {"45","60" },{"45","60" }
            //                      },
            //                      {
            //                        {"45","60" },{"45","60" }
            //                      }
            //                    };
            #endregion

            #region 13. Örnek - CiftBoyutlu static Diziler
            //string[,] veriler = new string[2, 6];
            //Random rnd = new Random();
            //for (int i = 0; i < veriler.GetLength(0); i++) // satırlar icin
            //{
            //    Console.Write("Adınız = ");
            //    veriler[i, 0] = Console.ReadLine();
            //    Console.Write("Soyadınız = ");
            //    veriler[i, 1] = Console.ReadLine();
            //    veriler[i, 2] = rnd.Next(101).ToString();
            //    veriler[i, 3] = rnd.Next(101).ToString();
            //    veriler[i, 4] = (int.Parse(veriler[i, 2]) * 0.4 + int.Parse(veriler[i, 3]) * 0.6).ToString();
            //    veriler[i, 5] = double.Parse(veriler[i, 4]) <= 60 ? "Kaldı" : "Geçti";
            //}

            //Console.WriteLine("Öğrenci Listesi");
            //Console.WriteLine("".PadLeft(50, '-'));
            //Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}",
            //                    "Adı",
            //                    "Soyadı",
            //                    "Vize",
            //                    "Final",
            //                    "Ortalama",
            //                    "Durum");
            //for (int satirIndis = 0; satirIndis < veriler.GetLength(0); satirIndis++) // Satırlar icin
            //{
            //    for (int sutunIndis = 0; sutunIndis < veriler.GetLength(1); sutunIndis++) //Sütunlar için
            //    {
            //        Console.Write("{0,-10}", veriler[satirIndis, sutunIndis]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 14. Örnek - İçİçe Diziler
            //List<string[]> veriler = new List<string[]>();
            //Random rnd = new Random();
            //while (true)
            //{
            //    string[] altVeri = new string[6];
            //    Console.Write("Adınız = ");
            //    altVeri[0] = Console.ReadLine();
            //    if (altVeri[0] == "0")
            //        break;

            //    Console.Write("Soyadınız = ");
            //    altVeri[1] = Console.ReadLine();
            //    altVeri[2] = rnd.Next(101).ToString();
            //    altVeri[3] = rnd.Next(101).ToString();
            //    altVeri[4] = (int.Parse(altVeri[2]) * 0.4 + int.Parse(altVeri[3]) * 0.6).ToString();
            //    altVeri[5] = double.Parse(altVeri[4]) <= 60 ? "Kaldı" : "Geçti";
            //    veriler.Add(altVeri);
            //}

            //Console.WriteLine("Öğrenci Listesi");
            //Console.WriteLine("".PadLeft(50, '-'));
            //Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}",
            //                    "Adı",
            //                    "Soyadı",
            //                    "Vize",
            //                    "Final",
            //                    "Ortalama",
            //                    "Durum");
            //for (int satirIndis = 0; satirIndis < veriler.Count; satirIndis++) // Satırlar icin
            //{
            //    for (int sutunIndis = 0; sutunIndis < veriler[satirIndis].Length; sutunIndis++) //Sütunlar için
            //    {
            //        if (sutunIndis >= 2 && sutunIndis <= 4)
            //            Console.Write("{0,10}", veriler[satirIndis][sutunIndis]);
            //        else
            //            Console.Write("{0,-10}", veriler[satirIndis][sutunIndis]);
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region 15. Örnek - İlk 3'e giren öğrencilerin listesini veren prg
            List<string[]> veriler = new List<string[]>();
            string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Tuba", "Hülya", "Cem", "Evren", "Muhammed", "Halim", "Yasin" };
            Random rnd = new Random();
            for (int i = 0; i < isimler.Length; i++)
            {
                string[] altVeri = new string[6];
                altVeri[0] = isimler[i];
                if (altVeri[0] == "0")
                    break;
                altVeri[1] = isimler[i];
                altVeri[2] = rnd.Next(101).ToString();
                altVeri[3] = rnd.Next(101).ToString();
                altVeri[4] = (int.Parse(altVeri[2]) * 0.4 + int.Parse(altVeri[3]) * 0.6).ToString();
                altVeri[5] = double.Parse(altVeri[4]) <= 60 ? "Kaldı" : "Geçti";
                veriler.Add(altVeri);
            }

            Console.WriteLine("Öğrenci Listesi");
            Console.WriteLine("".PadLeft(50, '-'));
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}",
                                "Adı",
                                "Soyadı",
                                "Vize",
                                "Final",
                                "Ortalama",
                                "Durum");
            for (int satirIndis = 0; satirIndis < veriler.Count; satirIndis++) // Satırlar icin
            {
                for (int sutunIndis = 0; sutunIndis < veriler[satirIndis].Length; sutunIndis++) //Sütunlar için
                {
                    if (sutunIndis >= 2 && sutunIndis <= 4)
                        Console.Write("{0,10}", veriler[satirIndis][sutunIndis]);
                    else
                        Console.Write("{0,-10}", veriler[satirIndis][sutunIndis]);
                }
                Console.WriteLine();
            }

            #region 1. Yol - Sıralama
            for (int i = 0; i < veriler.Count; i++)
            {
                for (int j = 0; j < veriler.Count; j++)
                {
                    if (double.Parse(veriler[i][4]) > double.Parse(veriler[j][4]))
                    {
                        string[] gecici = new string[veriler[i].Length];
                        veriler[i].CopyTo(gecici, 0);
                        veriler[j].CopyTo(veriler[i], 0);
                        gecici.CopyTo(veriler[j], 0);
                    }
                }
            }
            #endregion

            #region 2. Yol Sıralama
            veriler = veriler.OrderByDescending(item => double.Parse(item[4])).Take(3).ToList();
            #endregion


            Console.WriteLine("".PadLeft(50, '-'));
            Console.WriteLine("Öğrenci Sıralaması");
            Console.WriteLine("".PadLeft(50, '-'));
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}",
                               "Adı",
                               "Soyadı",
                               "Vize",
                               "Final",
                               "Ortalama",
                               "Durum");
            for (int satirIndis = 0; satirIndis < 3; satirIndis++)
            {
                for (int sutunIndis = 0; sutunIndis < veriler[satirIndis].Length; sutunIndis++)
                {
                    if (sutunIndis >= 2 && sutunIndis <= 4)
                        Console.Write("{0,10}", veriler[satirIndis][sutunIndis]);
                    else
                        Console.Write("{0,-10}", veriler[satirIndis][sutunIndis]);
                }
                Console.WriteLine();
            }


            #endregion
        }
    }
}
