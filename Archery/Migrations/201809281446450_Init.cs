namespace Archery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mail = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Archers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LicenseNumber = c.String(),
                        Mail = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Archers");
            DropTable("dbo.Administrators");
        }
    }
}
