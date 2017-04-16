namespace Rent_It.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToItemModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Items", "ItemTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Items", "NumberAvailable", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "ItemTypeId");
            AddForeignKey("dbo.Items", "ItemTypeId", "dbo.ItemTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ItemTypeId", "dbo.ItemTypes");
            DropIndex("dbo.Items", new[] { "ItemTypeId" });
            DropColumn("dbo.Items", "NumberAvailable");
            DropColumn("dbo.Items", "DateAdded");
            DropColumn("dbo.Items", "ItemTypeId");
            DropTable("dbo.ItemTypes");
        }
    }
}
