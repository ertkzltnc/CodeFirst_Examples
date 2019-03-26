using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_MToMRelation.DAL.Entity
{
    [Table("Teachers")]
    public class Teacher
    {
        public Teacher()
        {
            this.students = new HashSet<Student>();

        }

        [Key]
        public int TeacherID { get; set; }

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

        public virtual ICollection<Student> students { get; set; }
    }
}
