namespace RecruitmentCRM.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Email = c.String(),
                        LinkedinAccountUrl = c.String(),
                        FacebookAccountUrl = c.String(),
                        OtherSites = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        universityMajor = c.String(),
                        ExperienceYears = c.DateTime(nullable: false, storeType: "date"),
                        GraduatDate = c.DateTime(nullable: false, storeType: "date"),
                        ApplyDate = c.DateTime(nullable: false, storeType: "date"),
                        Country = c.String(),
                        Document = c.String(),
                        CreationDate = c.DateTime(nullable: false, storeType: "date"),
                        CreatedBy = c.Long(nullable: false),
                        UpdateDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedBy = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreatedBy = c.Long(nullable: false),
                        UpdateDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedBy = c.Long(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Students_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Students_Id)
                .Index(t => t.Students_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "Students_Id", "dbo.Students");
            DropIndex("dbo.Notes", new[] { "Students_Id" });
            DropTable("dbo.Notes");
            DropTable("dbo.Students");
        }
    }
}
