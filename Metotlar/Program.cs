using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        /// <summary>
        /// Ekrana merhaba dünya yazar
        /// </summary>
        public static void MesajVer()
        {
            Console.WriteLine("Merhaba Dünya");
            //return;
            //Console.WriteLine("Merhaba Dünya 2");
        }

        /// <summary>
        /// Ekrana Merhaba mesajını verir
        /// </summary>
        /// <param name="isim">Parametre olarak gönderilen degiskene selam verir</param>
        public static void MesajVer(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }

        /// <summary>
        /// Ekrana erhaba mesajını verir
        /// </summary>
        /// <param name="isim">Parametre olarak gönderilen degiskene selam verir</param>
        /// <param name="yas">Yas degerini girmeniz gerekmektedir.</param>
        public static void MesajVer(string isim, int yas)
        {
            Console.WriteLine("Merhaba " + yas);
        }

        public static string VeriDondur(string veri)
        {
            string data = "Merhaba " + veri;
            return data;
        }

        public static string Veri2Dondur(string veri)
        {
            string data = "Merhaba " + veri;
            return data;
        }

        //public static int BirArtir(int sayi)
        //{
        //    return ++sayi;
        //}

        public static void TarihVer()
        {
            Console.WriteLine(DateTime.Today);
        }

        public static int Faktoriyel(int sayi)
        {
            int carpim = 1;
            for (int i = sayi; i >= 2; i--)
                carpim *= i;
            return carpim;
        }

        public static bool AsalMi(int sayi)
        {
            for (int i = 2; i <= sayi / 2; i++) //Bolenleri dönmek icin
            {
                if (sayi % i == 0) //Asal Degildir
                    return false;
            }
            return true;
        }

        public static List<int> AradakiAsallar(int min, int max)
        {
            var dizi = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (AsalMi(i))
                    dizi.Add(i);
            }
            return dizi;
        }

        public static bool MukemmelMi(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i <= sayi / 2; i++)
            {
                if (sayi % i == 0)
                    toplam += i;
            }
            return sayi == toplam;
        }

        public static List<int> AradakiMukemmelSayilar(int min, int max)
        {
            var dizi = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (MukemmelMi(i))
                    dizi.Add(i);
            }
            return dizi;
        }

        public static void DiziYaz(List<int> dizi)
        {
            foreach (var item in dizi)
                Console.WriteLine(item);
        }
        public static void DiziYaz(params object[] veriler)
        {
            foreach (var item in veriler)
            {
                Console.WriteLine(item);
            }
        }

        public static bool DizideVarMi(object arananDeger, params object[] dizi)
        {
            return dizi.Contains(arananDeger);
        }

        public static bool DizideVarMi(object[] dizi, object arananDeger)
        {
            return dizi.Contains(arananDeger);
        }

        public static void BirArtir(int sayi)
        {
            sayi++;
        }

        public static void BirArtir(int[] sayi)
        {
            sayi[2]++;
        }

        public static bool CevirmeyiDene(string veri, out int sayi, out int sayi2)
        {
            sayi = 0;
            sayi2 = 40;
            bool cevrildimi;
            try
            {
                sayi = int.Parse(veri);
                cevrildimi = true;
            }
            catch (Exception)
            {
                cevrildimi = false;
            }
            return cevrildimi;
        }

        public static void MetotAdi(string a, int? b = null, int? c = null)
        {
            Console.WriteLine("Merhaba " + b);
        }

        #region Recursive Metotlar
        #region 1. Yol
        //static int toplam = 0;
        //public static void VeriYaz()
        //{
        //    toplam++;
        //    Console.WriteLine("BilgeAdam");
        //    if (toplam == 10)
        //        return;
        //    VeriYaz();
        //}
        #endregion

        #region 2.Yol
        //public static void VeriYaz(int TekrarSayisi)
        //{
        //    if (TekrarSayisi == 0)
        //        return;
        //    Console.WriteLine("BilgeAdam");
        //    VeriYaz(TekrarSayisi-1);
        //}
        #endregion

        #endregion

        #region Recursive ÖRnek 2
        #region 1. Yol
        //public static int Topla(int sayac, int toplam = 0)
        //{
        //    if (sayac == 0)
        //        return toplam;

        //    toplam = sayac + toplam;
        //    return Topla(sayac - 1, toplam);
        //}
        #endregion
        #region 2. Yol
        public static int Topla(int sayi)
        {
            if (sayi == 0)
                return sayi;
            return sayi + Topla(sayi - 1);
        }
        #endregion
        #endregion

        public static string Donustur(string metin)
        {
            char[] turkceKrk = { 'ç', 'Ç', 'ş', 'Ş', 'ı', 'İ', 'ğ', 'Ğ', 'ü', 'Ü', 'ö', 'Ö', ' ' };
            char[] ingKrk = { 'c', 'C', 's', 'S', 'i', 'I', 'g', 'G', 'u', 'U', 'o', 'O', '_' };
            for (int i = 0; i < turkceKrk.Length; i++)
                metin = metin.Replace(turkceKrk[i], ingKrk[i]);
            return metin;
        }

        public static bool PalindromMu(string metin)
        {
            char[] karakterler = metin.ToCharArray();
            char[] donusmusKarakterlerDizisi = karakterler.Reverse().ToArray();
            string donusmusVeri = new string(karakterler);
            return karakterler == donusmusKarakterlerDizisi;
        }

        static void Main(string[] args)
        {
            #region Birartir referans metodu için kullanıldı
            //int[] sayilar = { 1, 2, 3 };
            //BirArtir(sayilar);
            //Console.WriteLine(sayilar[2]);
            #endregion

            #region Out parametre olarak veri döndüren metotların çağırma şekli
            //bool durum = CevirmeyiDene("50", out int veri, out int veri2);
            //Console.WriteLine(veri2);
            #endregion

            //bool cevap = PalindromMu("madam");

        }


    }
}
