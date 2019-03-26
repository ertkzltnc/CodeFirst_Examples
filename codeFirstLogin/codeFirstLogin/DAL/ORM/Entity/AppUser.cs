using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstLogin.DAL.ORM.Entity
{
    [Table("Users")] // table adı belirleme  default olarak class name kullanıyor
    public class AppUser:BaseEntity
    {
        [MaxLength(30)] // default  degeri nvarchar(255) 
        public string LastName  { get; set; }
        [NotMapped] // tablo sutun olarak kullanmamak icin
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName)) // bosluk var mı kontrol
                {
                    return Name;
                }
                else
                {
                    return Name + " " + LastName;
                }
            }
        }
        [Required] // null gecilemesin diye default string null gecilebiir

        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public DateTime? Birth_Day { get; set; }
        public bool Gender { get; set; }






    }
}
