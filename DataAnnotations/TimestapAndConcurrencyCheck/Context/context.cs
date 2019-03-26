namespace TimestapAndConcurrencyCheck.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TimestapAndConcurrencyCheck.Entity;

    public class context : DbContext
    {

        public context()
            : base("name=context")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }



    }
}

  