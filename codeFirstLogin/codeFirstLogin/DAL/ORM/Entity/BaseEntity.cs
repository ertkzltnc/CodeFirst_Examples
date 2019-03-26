using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstLogin.DAL.ORM.Entity
{
    public class BaseEntity
    {
        [Key]
        //[Column(Order=1)]  colum sırası belirtme default degeri sıra ile yapılıyor
        public int ID { get; set; }
        public string Name { get; set; }
        [Column(TypeName="datetime2")] // tip degisme
        public DateTime? Added_Date{ get; set; }
        public bool isActive { get; set; }

    }
}
