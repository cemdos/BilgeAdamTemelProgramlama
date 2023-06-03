using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciOtomasyon2.Model
{
    public class Email
    {
        [Key]
        public int EmailId { get; set; }
        [DefaultValue("Tanımsız")]
        public string EmailAdresi { get; set; }
        public int? ID_Kullanici { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
