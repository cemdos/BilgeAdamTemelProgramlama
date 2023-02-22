using BenimKutuphanem.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimKutuphanem.Siniflarim
{
    public class Insan
    {
        public Insan()
        {
            Yas = 0;
            Boy = 50;
        }

        public Insan(string yas)
        {
            Yas = int.Parse(yas);
            Boy = 50;
        }

        public Insan(int Yas, int Boy)
        {
            this.Yas = Yas > 100 ? 100 : Yas;
            this.Boy = Boy;
        }

        public Insan(int Yas, int Boy,Cinsiyet Cinsiyeti)
        {
            this.Yas = Yas > 100 ? 100 : Yas;
            this.Boy = Boy;
            this.Cinsiyeti = Cinsiyeti;
        }


        public int Yas { get; protected set; } //= 0;
        public int Boy { get; protected set; } //= 50;
        public Cinsiyet Cinsiyeti { get; protected set; }

        public void Yaz()
        {
            Console.WriteLine($"Yas: {Yas}\t Boy: {Boy} \t Cinsiyet: {Cinsiyeti}");
        }

        public virtual void Yaz1()
        {
            Console.WriteLine($"Yas: {Yas}\t");
        }

        protected static void Yaz2()
        {
            Console.WriteLine($"Merhaba Dünya");
        }

    }
}
