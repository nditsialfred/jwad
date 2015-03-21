namespace JWAD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixth : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.JobRequirements", newName: "Jobs");
            AddColumn("dbo.JobSeekers", "Email", c => c.String());
            AddColumn("dbo.JobSeekers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobSeekers", "Password");
            DropColumn("dbo.JobSeekers", "Email");
            RenameTable(name: "dbo.Jobs", newName: "JobRequirements");
        }
    }
}
