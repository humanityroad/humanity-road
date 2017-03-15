namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateFieldEdit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TimeSheet", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TimeSheet", "Date", c => c.DateTime(nullable: false));
        }
    }
}
