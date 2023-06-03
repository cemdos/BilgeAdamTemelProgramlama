namespace KullaniciOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kullanici", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kullanici", "Email", c => c.String());
        }
    }
}
