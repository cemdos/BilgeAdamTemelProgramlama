using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Model
{
    [Table("UrunDetayi")]
    public class UrunDetayi:BaseModel
    {
        public int ID_Musteri { get; set; }
        public int ID_Urun { get; set; }
        public virtual Musteri AktifMusteri { get; set; }
        public virtual Urun AktifUrun { get; set; }
    }
}
