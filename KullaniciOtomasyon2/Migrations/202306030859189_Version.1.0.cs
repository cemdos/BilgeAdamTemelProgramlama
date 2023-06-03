namespace KullaniciOtomasyon2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fotografs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FotografYolu = c.String(),
                        ID_Kullanici = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Fotografs");
        }
    }
}
