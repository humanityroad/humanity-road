namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profilehistory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Volunteer", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Volunteer", "Role");
        }
    }
}
