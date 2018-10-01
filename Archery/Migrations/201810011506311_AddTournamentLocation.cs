namespace Archery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTournamentLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tournaments", "Location", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tournaments", "Location");
        }
    }
}
