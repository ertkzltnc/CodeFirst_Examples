using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_MToMRelation.DAL.Context;
using CodeFirst_MToMRelation.DAL.Entity;

namespace CodeFirst_MToMRelation
{
    public partial class FormRelationship : Form
    {
        FormStart formStart;
        UniversityContext db = DbSingleTone.GetInstance();
        int teacherId, studentID;
        public FormRelationship(FormStart fs)
        {
            formStart = fs;
            InitializeComponent();
        }

        private void FormRelationship_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formStart.Show();

        }
        private void FormRelationship_Load(object sender, EventArgs e)
        {
            
            GetStudent();
            GetTeacher();
            Fill();
        }
        public void GetTeacher()
        {
            var teacherList = db.Teachers.ToList();
           
            cbTeacher.DisplayMember = "FullName";
            cbTeacher.ValueMember = "TeacherID";
            cbTeacher.DataSource = teacherList;

        }
        public void GetStudent()
        {
            List<Student> studentList = db.Students.ToList();
            lbStudent.SelectedItem = false;
            lbStudent.DisplayMember = "FullName";
            lbStudent.ValueMember = "StudentID";
            lbStudent.DataSource = studentList;
            lbStudent.SelectedItem = -1;





        }
        public void Fill()
        {
           
            int teacherId = (int)cbTeacher.SelectedValue;
            Teacher teacher = db.Teachers.Find(teacherId);
            var teacherAndStudent = teacher.students.Select(x => new
            {
                teacher.TeacherID,
                teacherFullName=teacher.FullName,
                x.StudentID,
                studentFullName=x.FullName

            }).ToList();
            dgvRelationship.DataSource = teacherAndStudent;
        }
        private void btnRelationshipAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // yol 1
                //var studentIDList = from Student st in lbStudent.SelectedItems

                //        select st.StudentID;


                //foreach (var item in studentIDList)
                //{
                //    int teacherID = (int)cbTeacher.SelectedValue;

                //    Teacher teacher = db.Teachers.Find(teacherID);
                //    Student student = db.Students.Find((int)item);
                //    teacher.students.Add(student);

                //    db.SaveChanges();
                //      lbStudent.SelectedItems.Clear();

                //}
                //Fill();
                // yol 2
                int teacherID = (int)cbTeacher.SelectedValue;

                Teacher teacher = db.Teachers.Find(teacherID);
                foreach (Student item in lbStudent.SelectedItems)
                {
                    teacher.students.Add(item);
                }
                db.SaveChanges();
                lbStudent.SelectedItems.Clear();
                Fill();
                // tek tek eklme  yol 3 
                //foreach (var item in lbStudent.SelectedItems)
                //{
                //    int teacherID = (int)cbTeacher.SelectedValue;

                //    MessageBox.Show(""+item.ToString());


                //    Teacher teacher = db.Teachers.Find(teacherID);
                //    Student student = db.Students.Find(studentID);
                //    teacher.students.Add(student);

                //    db.SaveChanges();
                //}





            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
        }

        private void btnRelationshipDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRelationship.SelectedRows.Count == 1)
                {

                    
                    Teacher teacher = db.Teachers.Find(teacherId);
                    Student student = db.Students.Find(studentID);
                    teacher.students.Remove(student);
                    db.SaveChanges();
                    Fill();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }

       
        private void btnRelationshipDeleteSI_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRelationship.SelectedRows.Count > 1)
                {
                    foreach (DataGridViewRow drop in dgvRelationship.SelectedRows)
                    {
                        teacherId = Convert.ToInt32(drop.Cells[0].Value);
                        studentID = Convert.ToInt32(drop.Cells[2].Value);
                        Teacher teacher = db.Teachers.Find(teacherId);
                        Student student = db.Students.Find(studentID);
                        teacher.students.Remove(student);
                        db.SaveChanges();
                        Fill();
                    }

                }
                else
                {
                    MessageBox.Show("Erorr");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                teacherId = Convert.ToInt32(dgvRelationship.Rows[dgvRelationship.CurrentRow.Index].Cells[0].Value.ToString());
                studentID = Convert.ToInt32(dgvRelationship.Rows[dgvRelationship.CurrentRow.Index].Cells[2].Value.ToString());

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }

        private void lbStudent_Click(object sender, EventArgs e)
        {
            //studentID=(int)lbStudent.
        }

        private void cbTeacher_TextChanged(object sender, EventArgs e)
        {
            teacherId = (int)cbTeacher.SelectedValue;
            Fill();
        }
    }
}
