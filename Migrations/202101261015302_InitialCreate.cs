namespace Testing_GUI_Project_DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Citizens",
                c => new
                    {
                        CitizenId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PassWord = c.String(),
                        Email = c.String(),
                        ContactInfo = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.CitizenId);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        FacilityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        WebSite = c.String(),
                        Email = c.String(),
                        ContactInformation = c.String(),
                        Address = c.String(),
                        TypeofFacility = c.String(),
                        citizen_CitizenId = c.Int(),
                    })
                .PrimaryKey(t => t.FacilityId)
                .ForeignKey("dbo.Citizens", t => t.citizen_CitizenId)
                .Index(t => t.citizen_CitizenId);
            
            CreateTable(
                "dbo.Fora",
                c => new
                    {
                        ForumId = c.Int(nullable: false, identity: true),
                        Idea = c.String(),
                        citizen_CitizenId = c.Int(),
                    })
                .PrimaryKey(t => t.ForumId)
                .ForeignKey("dbo.Citizens", t => t.citizen_CitizenId)
                .Index(t => t.citizen_CitizenId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        SchoolId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                    })
                .PrimaryKey(t => t.SchoolId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PassWord = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Age = c.DateTime(nullable: false),
                        Grade = c.Int(nullable: false),
                        Address = c.String(),
                        School_SchoolId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Schools", t => t.School_SchoolId)
                .Index(t => t.School_SchoolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "School_SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Fora", "citizen_CitizenId", "dbo.Citizens");
            DropForeignKey("dbo.Facilities", "citizen_CitizenId", "dbo.Citizens");
            DropIndex("dbo.Students", new[] { "School_SchoolId" });
            DropIndex("dbo.Fora", new[] { "citizen_CitizenId" });
            DropIndex("dbo.Facilities", new[] { "citizen_CitizenId" });
            DropTable("dbo.Students");
            DropTable("dbo.Schools");
            DropTable("dbo.Fora");
            DropTable("dbo.Facilities");
            DropTable("dbo.Citizens");
            DropTable("dbo.Admins");
        }
    }
}
