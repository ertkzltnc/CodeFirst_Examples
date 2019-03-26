namespace CodeFirst_MToMRelation.Migrations
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
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SurName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SurName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.TeacherStudents",
                c => new
                    {
                        Teacher_TeacherID = c.Int(nullable: false),
                        Student_StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherID, t.Student_StudentID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentID, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherID)
                .Index(t => t.Student_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherStudents", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.TeacherStudents", "Teacher_TeacherID", "dbo.Teachers");
            DropIndex("dbo.TeacherStudents", new[] { "Student_StudentID" });
            DropIndex("dbo.TeacherStudents", new[] { "Teacher_TeacherID" });
            DropTable("dbo.TeacherStudents");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
