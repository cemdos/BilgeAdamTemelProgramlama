namespace KullaniciOtomasyon2.Migrations
{
    using KullaniciOtomasyon2.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KullaniciOtomasyon2.KullaniciContent>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KullaniciOtomasyon2.KullaniciContent context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Kullanici.AddOrUpdate(new Kullanici
            {
                Adi = "Cem",
                Soyadi = "DOS"
            });
            context.Kullanici.AddOrUpdate(new Kullanici
            {
                Adi = "Ali",
                Soyadi = "Yener"
            });
        }
    }
}
