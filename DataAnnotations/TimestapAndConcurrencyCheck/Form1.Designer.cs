namespace TimestapAndConcurrencyCheck
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdmin = new System.Windows.Forms.ToolStripButton();
            this.tsbUser = new System.Windows.Forms.ToolStripButton();
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.Label();
            this.Unitprice = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.grbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.grbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdmin,
            this.tsbUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdmin
            // 
            this.tsbAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdmin.Image")));
            this.tsbAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdmin.Name = "tsbAdmin";
            this.tsbAdmin.Size = new System.Drawing.Size(24, 24);
            this.tsbAdmin.Text = "Admin";
            this.tsbAdmin.Click += new System.EventHandler(this.tsbAdmin_Click);
            // 
            // tsbUser
            // 
            this.tsbUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbUser.Image")));
            this.tsbUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUser.Name = "tsbUser";
            this.tsbUser.Size = new System.Drawing.Size(24, 24);
            this.tsbUser.Text = "User";
            this.tsbUser.Click += new System.EventHandler(this.tsbUser_Click);
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.dgvProduct);
            this.grbAdmin.Controls.Add(this.Quantity);
            this.grbAdmin.Controls.Add(this.Unitprice);
            this.grbAdmin.Controls.Add(this.Product);
            this.grbAdmin.Controls.Add(this.btnUpdate);
            this.grbAdmin.Controls.Add(this.btnDelete);
            this.grbAdmin.Controls.Add(this.btnAdd);
            this.grbAdmin.Controls.Add(this.txtQuantity);
            this.grbAdmin.Controls.Add(this.txtUnitprice);
            this.grbAdmin.Controls.Add(this.txtProduct);
            this.grbAdmin.Location = new System.Drawing.Point(26, 76);
            this.grbAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAdmin.Size = new System.Drawing.Size(743, 327);
            this.grbAdmin.TabIndex = 1;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Add-Update (ADMIN)";
            this.grbAdmin.Enter += new System.EventHandler(this.grbAdmin_Enter);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(30, 154);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(581, 122);
            this.dgvProduct.TabIndex = 9;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(242, 16);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity";
            // 
            // Unitprice
            // 
            this.Unitprice.AutoSize = true;
            this.Unitprice.Location = new System.Drawing.Point(146, 16);
            this.Unitprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Unitprice.Name = "Unitprice";
            this.Unitprice.Size = new System.Drawing.Size(49, 13);
            this.Unitprice.TabIndex = 7;
            this.Unitprice.Text = "Unitprice";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(59, 16);
            this.Product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(44, 13);
            this.Product.TabIndex = 6;
            this.Product.Text = "Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 83);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 19);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(148, 83);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 83);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(244, 42);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(76, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(148, 42);
            this.txtUnitprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(76, 20);
            this.txtUnitprice.TabIndex = 1;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(59, 42);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(76, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // grbUser
            // 
            this.grbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbUser.Controls.Add(this.label1);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Controls.Add(this.btnOrderDelete);
            this.grbUser.Controls.Add(this.btnOrderAdd);
            this.grbUser.Controls.Add(this.dgvOrder);
            this.grbUser.Controls.Add(this.cbUser);
            this.grbUser.Controls.Add(this.txtOrderQuantity);
            this.grbUser.Controls.Add(this.cbProduct);
            this.grbUser.Location = new System.Drawing.Point(398, 37);
            this.grbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbUser.Name = "grbUser";
            this.grbUser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbUser.Size = new System.Drawing.Size(649, 341);
            this.grbUser.TabIndex = 2;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Order (USER)";
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Location = new System.Drawing.Point(116, 85);
            this.btnOrderDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(56, 19);
            this.btnOrderDelete.TabIndex = 7;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(31, 85);
            this.btnOrderAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(56, 19);
            this.btnOrderAdd.TabIndex = 6;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(16, 154);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(612, 132);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(16, 44);
            this.cbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(92, 21);
            this.cbUser.TabIndex = 2;
            this.cbUser.TextChanged += new System.EventHandler(this.cbUser_TextChanged);
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(248, 44);
            this.txtOrderQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(76, 20);
            this.txtOrderQuantity.TabIndex = 1;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(134, 44);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(92, 21);
            this.cbProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 537);
            this.Controls.Add(this.grbUser);
            this.Controls.Add(this.grbAdmin);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdmin;
        private System.Windows.Forms.ToolStripButton tsbUser;
        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Unitprice;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

