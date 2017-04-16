namespace Rent_It.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateItemTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ItemTypes (Name) VALUES ('Movie')");
            Sql("INSERT INTO ItemTypes (Name) VALUES ('Book')");
            Sql("INSERT INTO ItemTypes (Name) VALUES ('CD')");
            Sql("INSERT INTO ItemTypes (Name) VALUES ('Tool')");
            Sql("INSERT INTO ItemTypes (Name) VALUES ('Appliance')");
        }

        public override void Down()
        {
        }
    }
}
