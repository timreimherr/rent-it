namespace Rent_It.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Description");
        }
    }
}
