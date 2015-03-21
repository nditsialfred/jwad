namespace JWAD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JobRequirements", "EmployerId", "dbo.Employers");
            DropIndex("dbo.JobRequirements", new[] { "EmployerId" });
            DropColumn("dbo.JobRequirements", "EmployerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JobRequirements", "EmployerId", c => c.Int(nullable: false));
            CreateIndex("dbo.JobRequirements", "EmployerId");
            AddForeignKey("dbo.JobRequirements", "EmployerId", "dbo.Employers", "EmployerId", cascadeDelete: true);
        }
    }
}
