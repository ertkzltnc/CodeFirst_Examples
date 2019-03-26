using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codeFirstLogin.DAL.ORM.Entity
{
    public class Product:BaseEntity
    {
        public decimal? UnitPrice { get; set; }

        public short? UnitInStock { get; set; }
        [MaxLength(30)]
        public string QuantityPerUnit { get; set; }


    }
}
