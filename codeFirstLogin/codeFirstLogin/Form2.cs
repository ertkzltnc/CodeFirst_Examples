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
using codeFirstLogin.DAL.ORM.Entity;

namespace codeFirstLogin
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        public Form2(Form1 f1)
        {
            mainForm = f1;
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Name = txtUrunAdi.Text,
                Added_Date = DateTime.Now,
                UnitPrice = decimal.Parse(txtFiyat.Text),
                UnitInStock = short.Parse(txtStok.Text),
                QuantityPerUnit = txtBrimi.Text,
                isActive=true
                

            };
            using (ProjeContext db=new ProjeContext())
            {
                db.products.Add(p);
                db.SaveChanges();
            }
            MessageBox.Show("Kayıt Basarılı","Urun Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
