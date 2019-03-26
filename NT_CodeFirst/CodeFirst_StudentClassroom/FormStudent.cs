using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_StudentClassroom.DAL.ORM.Context;
using CodeFirst_StudentClassroom.DAL.ORM.Entity;


namespace CodeFirst_StudentClassroom
{
    public partial class FormStudent : Form
    {
        FormStart formStart;
        StudentClassroomContext db = new StudentClassroomContext();
        int studentID;
        string studentFullName;
        int count;
        public FormStudent(FormStart f)
        {
           
          
            InitializeComponent();
            formStart = f;

        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FullName = txtFullName.Text;
            student.ClassroomID=(int)cbClassroom.SelectedValue;
            db.Students.Add(student);
            db.SaveChanges();
            StudentFill();

        }
        public void StudentFill()
        {
            string classroomDescription = cbClassroom.Text;
            List<MyEntityStudent> studentList = db.Students.Where(x=>x.classroom.Description==classroomDescription).
                Select(x => new MyEntityStudent{
                    StudentID =x.StudentID,
                    FullName = x.FullName,
                    Classromm = x.classroom.Description
                }).ToList();
            dgvStudent.DataSource = studentList;
        }
        public void GetClassroom()
        {
            List<Classroom> classList= db.Classrooms.ToList();
            cbClassroom.DataSource = classList;
            cbClassroom.DisplayMember = "Description";
            cbClassroom.ValueMember = "ClassroomID";
          
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            GetClassroom();
            StudentFill();
           
        }

        private void FormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            formStart.Show();
            this.Hide();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studentID = Convert.ToInt32(dgvStudent.Rows[dgvStudent.CurrentRow.Index].Cells[0].Value.ToString());
         
            List<Student> student = db.Students.Where(x =>x.StudentID==studentID).ToList();
            GetClassroom();
            
            foreach (var item in student)
            {
                txtFullName.Text = item.FullName;
                cbClassroom.Text = item.classroom.Description;
            }

        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {

          
            if (dgvStudent.SelectedRows.Count == 1)
            {
               
                var student = db.Students.Find(studentID);
                db.Students.Remove(student);
                db.SaveChanges();
                StudentFill();

            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnStudentDeleteSI_Click(object sender, EventArgs e)
        {
          
            if (dgvStudent.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow drop in dgvStudent.SelectedRows)
                {
                    studentID = Convert.ToInt32(drop.Cells[0].Value);
                    var student = db.Students.Find(studentID);
                    db.Students.Remove(student);
                    db.SaveChanges();
                  
                    
                }
                StudentFill();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            var student = db.Students.Find(studentID);
            student.FullName = txtFullName.Text;
            student.ClassroomID = (int)cbClassroom.SelectedValue;
            db.SaveChanges();
            StudentFill();

        }

        private void cbClassroom_TextChanged(object sender, EventArgs e)
        {
            StudentFill();
        }
    }
}
