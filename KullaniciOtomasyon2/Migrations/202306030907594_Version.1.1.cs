namespace KullaniciOtomasyon2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        EmailId = c.Int(nullable: false, identity: true),
                        EmailAdresi = c.String(),
                    })
                .PrimaryKey(t => t.EmailId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emails");
        }
    }
}
