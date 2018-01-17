namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDbMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "State", c => c.String());
            AddColumn("dbo.People", "Zipcode", c => c.String());
            AddColumn("dbo.People", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Phone");
            DropColumn("dbo.People", "Zipcode");
            DropColumn("dbo.People", "State");
        }
    }
}
