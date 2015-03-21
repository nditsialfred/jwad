namespace JWAD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobSeekers", "Resume", c => c.String());
            DropColumn("dbo.JobSeekers", "Email");
            DropColumn("dbo.JobSeekers", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JobSeekers", "Password", c => c.String());
            AddColumn("dbo.JobSeekers", "Email", c => c.String());
            DropColumn("dbo.JobSeekers", "Resume");
        }
    }
}
