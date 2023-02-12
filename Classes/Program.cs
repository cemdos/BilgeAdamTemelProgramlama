using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    enum Yon
    {
        None = 0,
        sag = 1,
        sol = 2,
        yukari = 3,
        asagi = 4
    }

    class Bisiklet
    {
        public int hiz { get; private set;}
        //private int hiz;

        //public int Hiz
        //{
        //    get { return hiz; }
        //    set { hiz = value > 70 ? 70 : value; }
        //}

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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bisiklet a = new Bisiklet();
            Bisiklet b = new Bisiklet();
            a.Hizlan();
            a.Hizlan();
            a.Hizlan();
            a.Hizlan();
            a.Hizlan();
            Console.WriteLine(a.hiz);
        }
    }
}
