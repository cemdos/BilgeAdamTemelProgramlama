using BankaUygulamasi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public class Hesap
    {
        public HesapTipi HesapTipi { get; set; }
        public decimal Bakiye { get; set; }
        public Guid HesapNo { get; set; }
    }
}
