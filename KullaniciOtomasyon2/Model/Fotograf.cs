using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciOtomasyon2.Model
{
    public class Fotograf
    {
        public int ID { get; set; }
        public string FotografYolu { get; set; }
        public int? ID_Kullanici { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
