using Classes.Enums;
using Classes.objeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenimKutuphanem;
using BenimKutuphanem.Siniflarim;
using BenimKutuphanem.Enumlar;

namespace Classes
{
    internal class Program:Ogrenci
    {
        static void Main(string[] args)
        {
            #region 1. Örnek
            //Bisiklet a = new Bisiklet();
            //Bisiklet b = new Bisiklet();
            //Console.WriteLine(b.BisikletSayisi);
            //Bisiklet.Yaz();
            //Console.WriteLine(Bisiklet.PI);
            #endregion

            Insan a = new Insan(150, 70);
            Insan b = new Insan(150, 70, Cinsiyet.Erkek);
            Ogrenci c = new Ogrenci();
            Ogretmen d = new Ogretmen();
            Ogrenci e = new Ogrenci("0908199125",11,120);

            //Ogrenci.
        }
    }
}
