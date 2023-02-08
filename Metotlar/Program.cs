using System;
using System.Collections.Generic;
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

        public static void BirArtir(ref int sayi)
        {
            ++sayi;
        }

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

        public static List<int> AradakiAsallar(int min,int max)
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
            for (int i = 1; i <= sayi/2; i++)
            {
                if (sayi % i == 0)
                    toplam += i;
            }
            return sayi == toplam;
        }

        public static List<int> AradakiMukemmelSayilar(int min,int max)
        {
            var dizi = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (MukemmelMi(i))
                    dizi.Add(i);
            }
            return dizi;
        } 

        static void Main(string[] args)
        {
            var datalar = AradakiMukemmelSayilar(10, 1000);
            //Console.WriteLine(MukemmelMi(10));
        }
    }
}
