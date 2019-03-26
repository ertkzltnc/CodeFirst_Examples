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

namespace CodeFirst_MToMRelation
{
    public partial class FormStart : Form
    {
        UniversityContext db = DbSingleTone.GetInstance();
        public FormStart()
        {
            InitializeComponent();
        }

       


        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void tsmTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher formTeacher = new FormTeacher(this);
            this.Hide();
            formTeacher.Show();
        }
        private void tsmStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent(this);
            this.Hide();
            formStudent.Show();
        }

        private void tsmTandS_Click(object sender, EventArgs e)
        {
            FormRelationship formRelationship = new FormRelationship(this);
            this.Hide();
            formRelationship.Show();
        }
    }
}
