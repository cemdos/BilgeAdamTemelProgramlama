namespace KullaniciOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fotograf",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FotografYolu = c.String(unicode: false),
                        ID_Kullanici = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanici", t => t.ID_Kullanici)
                .Index(t => t.ID_Kullanici);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(unicode: false),
                        Sifre = c.String(unicode: false),
                        Adi = c.String(unicode: false),
                        Soyadi = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fotograf", "ID_Kullanici", "dbo.Kullanici");
            DropIndex("dbo.Fotograf", new[] { "ID_Kullanici" });
            DropTable("dbo.Kullanici");
            DropTable("dbo.Fotograf");
        }
    }
}
