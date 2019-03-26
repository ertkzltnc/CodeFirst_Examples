namespace CodeFirst_MToMRelation.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_MToMRelation.DAL.Context.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst_MToMRelation.DAL.Context.UniversityContext context)
        {
            context.Students.AddOrUpdate(x => x.StudentID,
                new DAL.Entity.Student() {StudentID=1,Name="Ert",SurName="Kzltnc" },
                new DAL.Entity.Student() {StudentID = 2, Name = "Suat", SurName = "Sevsin" },
                new DAL.Entity.Student() {StudentID = 3, Name = "Caner", SurName = "Alpaslan" },
                new DAL.Entity.Student() {StudentID = 4, Name = "Emre", SurName = "Ert�rk" }
                );
            context.Teachers.AddOrUpdate(x => x.TeacherID,
                new DAL.Entity.Teacher() { TeacherID = 1, Name = "Tolga", SurName = "Ayd�n" },
                new DAL.Entity.Teacher() { TeacherID = 2, Name = "Deniz", SurName = "Kara" },
                new DAL.Entity.Teacher() { TeacherID = 3, Name = "Bar�s", SurName = "Ozyer" }
                );
        }
    }
}
