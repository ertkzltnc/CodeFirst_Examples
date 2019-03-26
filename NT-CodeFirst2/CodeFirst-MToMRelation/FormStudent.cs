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
    public partial class FormStudent : Form
    {
        FormStart formStart;
        UniversityContext db = DbSingleTone.GetInstance();
        int studentID;
        public FormStudent(FormStart fs)
        {
            formStart = fs;
            InitializeComponent();
        }

        private void FormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formStart.Show();

        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            StudentFill();
            Clear();

        }
        public void StudentFill()
        {
           
            List<MyEntity> studentList = db.Students.Select(x => new MyEntity
                {
                    ID = x.StudentID,
                    Name=x.Name,
                    Surname = x.SurName
                }).ToList();
            dgvStudent.DataSource = studentList;
        }
        public void Clear()
        {
            txtStudentName.Text = "";
            txtStudentSurname.Text = "";
        }
      

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                student.Name = txtStudentName.Text;
                student.SurName = txtStudentSurname.Text;
                db.Students.Add(student);
                db.SaveChanges();
                Clear();
                StudentFill();

            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvStudent.SelectedRows.Count == 1)
                {

                    var student = db.Students.Find(studentID);
                    db.Students.Remove(student);
                    db.SaveChanges();
                    StudentFill();
                    Clear();

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

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var student = db.Students.Find(studentID);
                student.Name = txtStudentName.Text;
                student.SurName = txtStudentSurname.Text;
                db.SaveChanges();
                StudentFill();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("", ex.Message);
            }
        }

        private void btnStudenDeleteSI_Click(object sender, EventArgs e)
        {
            try
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
                    Clear();
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

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                studentID = Convert.ToInt32(dgvStudent.Rows[dgvStudent.CurrentRow.Index].Cells[0].Value.ToString());

                List<Student> student = db.Students.Where(x => x.StudentID == studentID).ToList();

                foreach (var item in student)
                {
                    txtStudentName.Text = item.Name;
                    txtStudentSurname.Text = item.SurName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
        }
    }
}
