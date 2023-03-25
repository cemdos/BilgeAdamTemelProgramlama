using BankaUygulamasi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Model
{
    public class Kullanici: BaseModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public string Tc { get; set; }
        public string Sifre { get; set; }
        public string MailAdresi { get; set; }
        public Rol Rolu { get; set; }
    }
}
