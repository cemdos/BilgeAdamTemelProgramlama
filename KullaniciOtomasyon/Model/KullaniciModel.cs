using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KullaniciOtomasyon.Model
{
    public partial class KullaniciModel : DbContext
    {
        public KullaniciModel()
            : base("name=KullaniciModel")
        {
        }

        public virtual DbSet<Fotograf> Fotograf { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fotograf>()
                .Property(e => e.FotografYolu)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.KullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Sifre)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Adi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Soyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Fotograf)
                .WithOptional(e => e.Kullanici)
                .HasForeignKey(e => e.ID_Kullanici);
        }
    }
}
