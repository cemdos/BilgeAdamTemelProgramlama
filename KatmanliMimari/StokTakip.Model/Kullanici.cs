using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Model
{
    [Table("Kullanici")]
    public class Kullanici: BaseModel
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
