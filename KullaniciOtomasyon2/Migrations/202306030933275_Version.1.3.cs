namespace KullaniciOtomasyon2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emails", "ID_Kullanici", c => c.Int());
            CreateIndex("dbo.Emails", "ID_Kullanici");
            AddForeignKey("dbo.Emails", "ID_Kullanici", "dbo.Kullanicis", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emails", "ID_Kullanici", "dbo.Kullanicis");
            DropIndex("dbo.Emails", new[] { "ID_Kullanici" });
            AlterColumn("dbo.Emails", "ID_Kullanici", c => c.Int(nullable: false));
        }
    }
}
