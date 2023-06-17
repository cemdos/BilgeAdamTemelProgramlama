using StokTakip.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Model
{
    [Table("Musteri")]
    public class Musteri:BaseModel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public virtual ICollection<UrunDetayi> UrunDetayList { get; set; }
    }
}
