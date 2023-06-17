using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using StokTakip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DAL.EntityFramework
{
    public class StokTakipContext:DbContext
    {
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<UrunDetayi> UrunDetayi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.UrunDetayList)
                .WithOne(e => e.AktifMusteri)
                .HasForeignKey(e => e.ID_Musteri)
                .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunDetayList)
                .WithOne(e => e.AktifUrun)
                .HasForeignKey(e => e.ID_Urun)
                .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Kullanici>().HasData(new Kullanici{ ID=10, KullaniciAdi = "cemdos", Sifre = "1234", CreDate = DateTime.Now,Deleted=false});
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici { ID=20, KullaniciAdi = "ali", Sifre = "1234", CreDate = DateTime.Now, Deleted = false });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string sqlBaglantisi = System.Configuration.ConfigurationManager.ConnectionString[$"SqlBaglanti"].ConnectionString;
            string sqlBaglantisi = "Server=DESKTOP-FH3V2M3\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True;TrustServerCertificate=True";

            optionsBuilder.UseSqlServer(sqlBaglantisi);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
