using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimestapAndConcurrencyCheck.Entity
{
    public class Product:BaseEntity
    {
        public Product()
        {
            this.users = new HashSet<User>();
        }
        [ConcurrencyCheck]
        public int Unitprice { get; set; }

        public int Quantity { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
        public ICollection<User> users { get; set; }


    }
}
