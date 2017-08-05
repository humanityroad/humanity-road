namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateofJoin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Volunteer", "DateofJoin", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Volunteer", "DateofJoin");
        }
    }
}
