namespace CodeFirst_MToMRelation.DAL.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CodeFirst_MToMRelation.DAL.Entity;
    public class UniversityContext : DbContext
    {
      
        public UniversityContext()
            : base("name=UniversityContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}