using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimestapAndConcurrencyCheck.Context;
using TimestapAndConcurrencyCheck.Entity;

namespace TimestapAndConcurrencyCheck
{
    public partial class Form1 : Form
    {
        context db = new context();
        int productID;
        int userID;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.FullName = txtProduct.Text;
            p.Unitprice =int.Parse( txtUnitprice.Text);
            p.Quantity = int.Parse(txtQuantity.Text);
            db.Products.Add(p);
            db.SaveChanges();
            ProductFill();

            
        }
        public void ProductFill()
        {
            var p = db.Products.Select(x => new 
            {
                x.ID,
                x.FullName,
                x.Quantity,
                x.Unitprice
                
            }).ToList();
            dgvProduct.DataSource = p;
        }

        private void tsbAdmin_Click(object sender, EventArgs e)
        {
            ProductFill();
         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var p = db.Products.Find(productID);
            db.Products.Remove(p);
            db.SaveChanges();
            ProductFill();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productID = Convert.ToInt32(dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString());
            var product = db.Products.Find(productID);
            txtProduct.Text = product.FullName;
            txtUnitprice.Text = product.Unitprice.ToString();
            txtQuantity.Text = product.Quantity.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var p = db.Products.Find(productID);
            p.FullName = txtProduct.Text;
            p.Unitprice = int.Parse(txtUnitprice.Text);
            p.Quantity = int.Parse(txtQuantity.Text);
            db.SaveChanges();
            ProductFill();
        }
        public void OrderFill()
        {
            //userID = (int)cbUser.SelectedValue;
           
            //User user = db.Users.Find(userID);
            //var orderdetails =user.products.Select(x => new
            //{
            //    User=user.ID,
              
            //    Product=x.ID,
            //    x.Unitprice,
            //    x.Quantity,
            //    Total=x.Quantity*x.Unitprice
               

            //}).ToList();
            //dgvOrder.DataSource = orderdetails;
            // farklı yol

            var od=(from c in db.Users.Where(x=>x.products.Any()) from p
                    in db.Products.Where(y=>y.users.Contains(c))
                    select new {c.ID,Product=p.ID,p.Unitprice,p.Quantity,Total=p.Quantity*p.Unitprice }).ToList();
            dgvOrder.DataSource = od;
        }

        private void tsbUser_Click(object sender, EventArgs e)
        {
           
            GetOrder();
            GetUser();
            OrderFill();

        }
        public void GetUser()
        {
            var users = db.Users.ToList();

            cbUser.DisplayMember = "FullName";
            cbUser.ValueMember = "ID";
            cbUser.DataSource = users;

        }
        public void GetOrder()
        {
            var product = db.Products.ToList();

            cbProduct.DisplayMember = "FullName";
            cbProduct.ValueMember = "ID";
            cbProduct.DataSource = product;

        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            userID = (int)cbUser.SelectedValue;
            productID = (int)cbProduct.SelectedValue;
            var user = db.Users.Find(userID);
            var product = db.Products.Find(productID);
            user.products.Add(product);
            db.SaveChanges();
            OrderFill();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = Convert.ToInt32(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value.ToString());
            productID = Convert.ToInt32(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[2].Value.ToString());
            
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            userID = (int)cbUser.SelectedValue;
            productID = (int)cbProduct.SelectedValue;
            var user = db.Users.Find(userID);
            var product = db.Products.Find(productID);
            user.products.Remove(product);
            db.SaveChanges();
            OrderFill();
        }

        private void cbUser_TextChanged(object sender, EventArgs e)
        {
            OrderFill();
        }

        private void grbAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
