namespace KullaniciOtomasyon.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fotograf")]
    public partial class Fotograf
    {
        public int ID { get; set; }

        public string FotografYolu { get; set; }

        public int? ID_Kullanici { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
