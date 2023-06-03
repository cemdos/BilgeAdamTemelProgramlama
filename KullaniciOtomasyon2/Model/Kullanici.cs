using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciOtomasyon2.Model
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public virtual ICollection<Fotograf> FotografList { get; set; }
        public virtual ICollection<Email> EmailList { get; set; }
    }
}
