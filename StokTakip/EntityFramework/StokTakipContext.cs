using Microsoft.EntityFrameworkCore;
using StokTakip.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.EntityFramework
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

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEV
            var ortamDegeri = "Dev";
#elif TEST
            var ortamDegeri = "Test";
#else
            var ortamDegeri = "Prod";
#endif
            //var ortamDegeri= System.Environment.GetEnvironmentVariable("Ortam");
            string sqlBaglantisi = ConfigurationManager.ConnectionStrings[$"SqlBaglanti{ortamDegeri}"].ConnectionString;

            optionsBuilder.UseSqlServer(sqlBaglantisi);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
