using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using codeFirstLogin.DAL.ORM.Context;

namespace codeFirstLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (db.users.Any(x => x.UserName == txtKullanici.Text && x.Password == txtSifre.Text))
            {
                Form2 f2 = new Form2(this);
                f2.Show();
                this.Hide();
                lblSonuc.Visible = false;
            }
            else
            {
                lblSonuc.Text = "Kullanıcı Adi veya Sifre Hatali";
                lblSonuc.Visible = true;
            }
        }
        ProjeContext db = new ProjeContext();

        private void grbGiris_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
