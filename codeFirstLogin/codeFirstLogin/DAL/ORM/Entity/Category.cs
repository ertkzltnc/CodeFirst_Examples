using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codeFirstLogin.DAL.ORM.Entity
{
    public class Category:BaseEntity
    {
        [MaxLength(255)]
        public string Description { get; set; }
        
        
    }
}
