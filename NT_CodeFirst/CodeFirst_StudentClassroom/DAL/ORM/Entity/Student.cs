using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_StudentClassroom.DAL.ORM.Entity
{
    public class Student
    {
        [Key]
        public long StudentID { get; set; }

        [MaxLength(150)]
        [Required]
        public string FullName { get; set; }
        public int ClassroomID { get; set; }

        public virtual Classroom classroom { get; set; }
    }
}
