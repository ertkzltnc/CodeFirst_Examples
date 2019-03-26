namespace CodeFirst_StudentClassroom.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_StudentClassroom.DAL.ORM.Context.StudentClassroomContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CodeFirst_StudentClassroom.DAL.ORM.Context.StudentClassroomContext context)
        {
            //context.Classrooms.AddOrUpdate(x => x.ClassroomID,
            //   new DAL.ORM.Entity.Classroom() { ClassroomID = 4, Description = "202" },
            //     new DAL.ORM.Entity.Classroom() { ClassroomID = 5, Description = "203" }
            //   );
            //context.Students.AddOrUpdate(x => x.StudentID,
            //    new DAL.ORM.Entity.Student { StudentID = 3, FullName = "suat" ,ClassroomID=3},
            //     new DAL.ORM.Entity.Student { StudentID = 4, FullName = "caner" ,ClassroomID=4}

            //    );

        }
    }
}
