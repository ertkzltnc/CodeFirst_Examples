namespace CodeFirst_StudentClassroom.DAL.ORM.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CodeFirst_StudentClassroom.DAL.ORM.Entity;

    public class StudentClassroomContext : DbContext
    {
        // Your context has been configured to use a 'StudentClassroomContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_StudentClassroom.DAL.ORM.Context.StudentClassroomContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentClassroomContext' 
        // connection string in the application configuration file.
        public StudentClassroomContext()
            : base("name=StudentClassroomContext")
        {
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Classroom> Classrooms { get; set; }

    }

   
}