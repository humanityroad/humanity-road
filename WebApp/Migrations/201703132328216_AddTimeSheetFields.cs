namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeSheetFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TimeSheet", "Action", c => c.String());
            AddColumn("dbo.TimeSheet", "ActionNotes", c => c.String());
            AddColumn("dbo.TimeSheet", "EventType", c => c.String());
            AddColumn("dbo.TimeSheet", "EventTypeNotes", c => c.String());
            AddColumn("dbo.TimeSheet", "Location", c => c.String());
            AddColumn("dbo.TimeSheet", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TimeSheet", "IsActive");
            DropColumn("dbo.TimeSheet", "Location");
            DropColumn("dbo.TimeSheet", "EventTypeNotes");
            DropColumn("dbo.TimeSheet", "EventType");
            DropColumn("dbo.TimeSheet", "ActionNotes");
            DropColumn("dbo.TimeSheet", "Action");
        }
    }
}
