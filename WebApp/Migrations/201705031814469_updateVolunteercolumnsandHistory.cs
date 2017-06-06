namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateVolunteercolumnsandHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfileHistory",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Reason = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Volunteer", "AgeGroups", c => c.String());
            AddColumn("dbo.Volunteer", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Volunteer", "Status");
            DropColumn("dbo.Volunteer", "AgeGroups");
            DropTable("dbo.ProfileHistory");
        }
    }
}
