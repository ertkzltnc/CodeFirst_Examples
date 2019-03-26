using CodeFirst_StudentClassroom.DAL.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_StudentClassroom.DAL.ORM.Entity;

namespace CodeFirst_StudentClassroom
{
    public partial class FormClassroom : Form
    {
        FormStart formStart;
        StudentClassroomContext db = new StudentClassroomContext();
        int classroomID;
      
        public FormClassroom(FormStart f)
        {
            InitializeComponent();
            formStart = f;
        }

        private void btnClassroomAdd_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom();
            classroom.Description = txtClassroom.Text;
            db.Classrooms.Add(classroom);
            db.SaveChanges();
            ClassroomFill();
        }
        public void ClassroomFill()
        {
           
            List<MyEntityClass> classroomList = db.Classrooms.Select(x => new MyEntityClass
            {
                ClassroomID = x.ClassroomID,
                FullName = x.Description
            }).ToList();
            dgvClassroom.DataSource = classroomList;
            //2. Yol
            //dgvClassroom.DataSource = db.Classrooms.Select(x => new 
            //{
            //    x.ClassroomID,
            //    x.Description
            //}).ToList();
        }

        private void FormClassroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            formStart.Show();
            this.Hide();
        }

        private void dgvClassroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classroomID= Convert.ToInt32(dgvClassroom.Rows[dgvClassroom.CurrentRow.Index].Cells[0].Value.ToString());
            txtClassroom.Text = dgvClassroom.Rows[dgvClassroom.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnClassroomDelete_Click(object sender, EventArgs e)
        {
           
            if (dgvClassroom.SelectedRows.Count==1)
            {
                
                var classroom = db.Classrooms.Find(classroomID);
                db.Classrooms.Remove(classroom);
                db.SaveChanges();
                ClassroomFill();

            }
            else
            {
                MessageBox.Show("Error");
            }
           
        }

        private void btnClassroomUpdate_Click(object sender, EventArgs e)
        {
            
            var classroom = db.Classrooms.Find(classroomID);
            classroom.Description = txtClassroom.Text;
            db.SaveChanges();
            ClassroomFill();
            
        }

        private void FormClassroom_Load(object sender, EventArgs e)
        {
            ClassroomFill();
        }

        private void btnClassroomDeleteSI_Click(object sender, EventArgs e)
        {
           
            if (dgvClassroom.SelectedRows.Count>1)
            {
                foreach (DataGridViewRow drop in dgvClassroom.SelectedRows)
                {
                    classroomID = Convert.ToInt32(drop.Cells[0].Value);
                    var classroom = db.Classrooms.Find(classroomID);
                    db.Classrooms.Remove(classroom);
                    db.SaveChanges();
                   
                   

                }
                ClassroomFill();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
