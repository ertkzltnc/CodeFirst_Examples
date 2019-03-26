namespace TimestapAndConcurrencyCheck.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TimestapAndConcurrencyCheck.Context.context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimestapAndConcurrencyCheck.Context.context context)
        {
            context.Admins.AddOrUpdate(x => x.ID,
               new Entity.Admin() { ID = 1,FullName = "Ert"},
               new Entity.Admin() { ID = 2, FullName = "Suat" }


               );
            context.Users.AddOrUpdate(x => x.ID,
              new Entity.User() { ID = 1, FullName = "Caner" },
              new Entity.User() { ID = 2, FullName = "Emre" }


              );
        }
    }
}
