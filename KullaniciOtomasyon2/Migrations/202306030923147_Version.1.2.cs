namespace KullaniciOtomasyon2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emails", "ID_Kullanici", c => c.Int(nullable: false));
            AlterColumn("dbo.Fotografs", "ID_Kullanici", c => c.Int());
            CreateIndex("dbo.Fotografs", "ID_Kullanici");
            AddForeignKey("dbo.Fotografs", "ID_Kullanici", "dbo.Kullanicis", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fotografs", "ID_Kullanici", "dbo.Kullanicis");
            DropIndex("dbo.Fotografs", new[] { "ID_Kullanici" });
            AlterColumn("dbo.Fotografs", "ID_Kullanici", c => c.Int(nullable: false));
            DropColumn("dbo.Emails", "ID_Kullanici");
        }
    }
}
