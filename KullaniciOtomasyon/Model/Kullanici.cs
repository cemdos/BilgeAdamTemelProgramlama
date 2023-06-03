namespace KullaniciOtomasyon.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Fotograf = new HashSet<Fotograf>();
        }

        public int ID { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fotograf> Fotograf { get; set; }
    }
}
