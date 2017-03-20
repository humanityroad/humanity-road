namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AcceptConductTerms : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Volunteer", "AcceptConductTerms", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Volunteer", "AcceptConductTerms", c => c.String());
        }
    }
}
