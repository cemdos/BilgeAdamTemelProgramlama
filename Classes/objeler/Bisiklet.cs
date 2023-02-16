using Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.objeler
{
    class Bisiklet
    {
        public const double PI = 3.14;
        public int BisikletSayisi=0;

        public Bisiklet()
        {
            Renk = Renk.Kirmizi;
            hiz = 0;
            vites = 1;
            yonu = Yon.yukari;
            BisikletSayisi++;
        }

        public Bisiklet(Renk rengi)
        {
            Renk = rengi;
            hiz = 0;
            vites = 1;
            yonu = Yon.yukari;
        }

        public Bisiklet(Renk Renk, int hiz)
        {
            this.Renk = Renk;
            this.hiz = hiz;
            vites = 1;
            yonu = Yon.yukari;
        }

        //public int hiz;
        public Renk Renk { get; set; }

        private int hiz;

        public int Hiz
        {
            get { return hiz; }
            set { hiz = value > 70 ? 70 : value; }
        }

        private int vites;
        private Yon yonu;

        public void Hizlan()
        {
            if (hiz >= 80)
            {
                hiz = 80;
                return;
            }
            hiz += 20;
        }
        public static void Yaz()
        {
            Console.WriteLine("Merhaba Dünya");
        }

        public void RenkDegistir(Renk rengi)
        {
            Renk = (Renk)7;
        }
    }
}
