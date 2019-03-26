using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst_StudentClassroom.DAL.ORM.Entity
{
    [Table("Classrooms")]
    public class Classroom
    {
        public Classroom()
        {
            this.students = new HashSet<Student>();
        }

        [Key]
        public int ClassroomID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Student> students { get; set; }
  
    }
}
