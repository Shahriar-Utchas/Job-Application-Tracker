namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        application_id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        company_name = c.String(),
                        position = c.String(),
                        date_applied = c.DateTime(nullable: false),
                        status = c.String(),
                        notes = c.String(),
                    })
                .PrimaryKey(t => t.application_id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applications", "user_id", "dbo.Users");
            DropIndex("dbo.Applications", new[] { "user_id" });
            DropTable("dbo.Users");
            DropTable("dbo.Applications");
        }
    }
}
