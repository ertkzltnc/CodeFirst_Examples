using codeFirstLogin.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstLogin.DAL.ORM.Context
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString =
                @"server=.;Database=CodeFirstDB;uid=kzltnc;pwd=01";
        }
            
       
            
              
        public DbSet<AppUser> users { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
