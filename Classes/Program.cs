using BenimKutuphanem;
using Classes.Enums;
using Classes.objeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bisiklet a = new Bisiklet();
            Bisiklet b = new Bisiklet();
            Console.WriteLine(b.BisikletSayisi);
            Bisiklet.Yaz();
            Console.WriteLine(Bisiklet.PI);
         
        }
    }
}
