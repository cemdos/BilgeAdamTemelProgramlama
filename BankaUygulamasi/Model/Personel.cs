using BankaUygulamasi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public class Personel:Kullanici
    {
        public Departman Departmani { get; set; }
    }
}
