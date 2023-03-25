using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public abstract class BaseModel
    {
        public DateTime OlusturmaTarihi { get; set; }
        public Boolean SilindiMi { get; set; }
        public Kullanici SilenKullanici { get; set; }
        public DateTime SilmeTarihi { get; set; }
        public DateTime DegistirmeTarihi { get; set; }
        public Kullanici DegistirenKullanici { get; set; }
    }
}
