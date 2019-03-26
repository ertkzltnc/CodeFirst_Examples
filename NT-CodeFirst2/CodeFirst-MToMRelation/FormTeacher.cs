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
    public partial class FormTeacher : Form
    {
        FormStart formStart;
        UniversityContext db = DbSingleTone.GetInstance();
        int teacherID;
        public FormTeacher(FormStart fs)
        {
            formStart = fs;
            InitializeComponent();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            Clear();
            TeacherFill();
        }

        private void FormTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formStart.Show();
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher tc = new Teacher();
                tc.Name = txtTeacherName.Text;
                tc.SurName = txtTeacherSurname.Text;
                db.Teachers.Add(tc);
                db.SaveChanges();
                TeacherFill();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
        }
        public void Clear()
        {
            txtTeacherName.Text = "";
            txtTeacherSurname.Text = "";
        }
        public void TeacherFill()
        {
            List<MyEntity> teacherList = db.Teachers.Select(x => new  MyEntity
            {
                ID=x.TeacherID,
                Name=x.Name,
                Surname=x.SurName
            }).ToList();
            dgvTeacher.DataSource = teacherList;
        }

        private void btnTeacherDeleteSI_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgvTeacher.SelectedRows.Count > 1)
                {
                    foreach (DataGridViewRow drow in dgvTeacher.SelectedRows)
                    {
                        teacherID = Convert.ToInt32(drow.Cells[0].Value);
                        var teacher = db.Teachers.Find(teacherID);
                        db.Teachers.Remove(teacher);
                        db.SaveChanges();


                    }
                    TeacherFill();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dgvTeacher.SelectedRows.Count==1)
                {
                    var teacher = db.Teachers.Find(teacherID);
                    db.Teachers.Remove(teacher);
                    db.SaveChanges();
                }
                TeacherFill();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                teacherID = Convert.ToInt32(dgvTeacher.Rows[dgvTeacher.CurrentRow.Index].Cells[0].Value.ToString());

                List<Teacher> teacher = db.Teachers.Where(x => x.TeacherID == teacherID).ToList();


                foreach (var item in teacher)
                {
                    txtTeacherName.Text = item.Name;
                    txtTeacherSurname.Text = item.SurName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
        }

        private void btnTeacherUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = db.Teachers.Find(teacherID);
                teacher.Name = txtTeacherName.Text;
                teacher.SurName = txtTeacherSurname.Text;
                db.SaveChanges();
                Clear();
                TeacherFill();
            }
            catch (Exception ex)
            {

                MessageBox.Show("",ex.Message);
            }
            
        }
    }
}
