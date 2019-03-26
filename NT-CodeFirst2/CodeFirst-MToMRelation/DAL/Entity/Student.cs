using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_MToMRelation.DAL.Entity
{
    [Table("Students")]
    public class Student
    {
        public Student()
        {
            this.teachers = new HashSet<Teacher>();
        }
        [Key]
        public int StudentID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SurName { get; set; }
        [NotMapped] // tablo sutun olarak kullanmamak icin
        public string FullName
        {
            get
            {
                return Name + " " + SurName;
            }
        }
        public virtual ICollection<Teacher> teachers { get; set; }
    }
}
