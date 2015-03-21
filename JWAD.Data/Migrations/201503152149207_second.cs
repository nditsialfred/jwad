namespace JWAD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        EmployerId = c.Int(nullable: false, identity: true),
                        EmployerName = c.String(),
                        EmployerUrl = c.String(),
                    })
                .PrimaryKey(t => t.EmployerId);
            
            CreateTable(
                "dbo.JobRequirements",
                c => new
                    {
                        JobRequirementId = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        JobDescription = c.String(),
                        JobCity = c.String(),
                        JobState = c.String(),
                        JobZipCode = c.Int(nullable: false),
                        EmployerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobRequirementId)
                .ForeignKey("dbo.Employers", t => t.EmployerId, cascadeDelete: true)
                .Index(t => t.EmployerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobRequirements", "EmployerId", "dbo.Employers");
            DropIndex("dbo.JobRequirements", new[] { "EmployerId" });
            DropTable("dbo.JobRequirements");
            DropTable("dbo.Employers");
        }
    }
}
