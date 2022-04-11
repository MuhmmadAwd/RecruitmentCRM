namespace GlobalDev.entitiy.Migrations
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
                        FirstName = c.String(),
                        SecondName = c.String(),
                        ThirdName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Email = c.String(),
                        LinkedinAccount = c.String(),
                        Experience = c.String(),
                        SeniorityLevel = c.String(),
                        StudySubject = c.String(),
                        GraduatDate = c.DateTime(nullable: false),
                        ApplyDate = c.DateTime(nullable: false),
                        Country = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
