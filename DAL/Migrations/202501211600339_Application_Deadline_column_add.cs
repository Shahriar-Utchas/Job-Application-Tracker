namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Application_Deadline_column_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applications", "deadline", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applications", "deadline");
        }
    }
}
