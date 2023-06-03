namespace KullaniciOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kullanici", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kullanici", "Email");
        }
    }
}
