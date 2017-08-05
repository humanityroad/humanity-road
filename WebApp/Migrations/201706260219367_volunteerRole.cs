namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class volunteerRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "RoleID", c => c.String());
            AddColumn("dbo.Roles", "RoleDesc", c => c.String());
            AddColumn("dbo.Roles", "RoleClassification", c => c.String());       

    }
        
        public override void Down()
        {
           DropColumn("dbo.Roles", "RoleID");
           DropColumn("dbo.Roles", "RoleDesc");
           DropColumn("dbo.Roles", "RoleClassification");
    }
    }
}
