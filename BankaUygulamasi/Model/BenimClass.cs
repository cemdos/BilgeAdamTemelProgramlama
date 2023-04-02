using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    internal class BenimClass : IBenimClass
    {
        public Hesap HesapAra(string hesapNo)
        {
            throw new NotImplementedException();
        }

        public string Oku()
        {
            throw new NotImplementedException();
        }

        public void Yaz(string veri)
        {
            throw new NotImplementedException();
        }
    }

    internal class BenimClass2 : IBenimClass
    {
        public Hesap HesapAra(string hesapNo)
        {
            Console.WriteLine();
            throw new NotImplementedException();
        }

        public string Oku()
        {
            Console.WriteLine();
            throw new NotImplementedException();
        }

        public void Yaz(string veri)
        {
            Console.WriteLine();
            throw new NotImplementedException();
        }
    }
}
