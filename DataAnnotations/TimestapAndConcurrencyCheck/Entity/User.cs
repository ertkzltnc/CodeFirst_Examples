using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimestapAndConcurrencyCheck.Entity
{
    public class User : BaseEntity
    {
        public User()
        {
            this.products = new HashSet<Product>();
        }
        public ICollection<Product> products {get; set; }
    }
}
