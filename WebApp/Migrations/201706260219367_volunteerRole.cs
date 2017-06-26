namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class volunteerRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Volunteer", "RoleID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Volunteer", "RoleID");
        }
    }
}
