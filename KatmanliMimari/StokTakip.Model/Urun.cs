using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Model
{
    [Table("Urun")]
    public class Urun:BaseModel
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public decimal BirimFiyat { get; set; }
        public virtual ICollection<UrunDetayi> UrunDetayList { get; set; }
    }
}
