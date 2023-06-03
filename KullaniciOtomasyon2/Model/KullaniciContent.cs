using KullaniciOtomasyon2.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace KullaniciOtomasyon2
{
    public class KullaniciContent : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KullaniciOtomasyon2.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public KullaniciContent()
            : base("name=KullaniciDbBaglantiMetni")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Fotograf> Fotograf { get; set; }
        public virtual DbSet<Email> Email { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>()
            .HasMany(e => e.FotografList)
            .WithOptional(e => e.Kullanici)
            .HasForeignKey(e => e.ID_Kullanici);

            modelBuilder.Entity<Kullanici>()
            .HasMany(e => e.EmailList)
            .WithOptional(e => e.Kullanici)
            .HasForeignKey(e => e.ID_Kullanici);
        }
    }
}