using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public interface IBenimClass
    {
        void Yaz(string veri);
        string Oku();
        Hesap HesapAra(string hesapNo);
    }
}
