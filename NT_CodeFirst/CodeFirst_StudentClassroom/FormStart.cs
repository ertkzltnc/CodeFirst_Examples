using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_StudentClassroom
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void tsmStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent(this);
            formStudent.Show();
            this.Hide();
        }

        private void tsmClassroom_Click(object sender, EventArgs e)
        {

            FormClassroom  formClassroom = new FormClassroom(this);
            formClassroom.Show();
            this.Hide();
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
