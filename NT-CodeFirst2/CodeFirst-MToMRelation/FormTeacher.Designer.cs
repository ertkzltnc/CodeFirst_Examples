namespace CodeFirst_MToMRelation
{
    partial class FormTeacher
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btnTeacherDeleteSI = new System.Windows.Forms.Button();
            this.btnTeacherUpdate = new System.Windows.Forms.Button();
            this.btnTeacherDelete = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.txtTeacherSurname = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.lblSurnameTeacher = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(66, 231);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowTemplate.Height = 24;
            this.dgvTeacher.Size = new System.Drawing.Size(572, 150);
            this.dgvTeacher.TabIndex = 17;
            this.dgvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacher_CellClick);
            // 
            // btnTeacherDeleteSI
            // 
            this.btnTeacherDeleteSI.Location = new System.Drawing.Point(359, 161);
            this.btnTeacherDeleteSI.Name = "btnTeacherDeleteSI";
            this.btnTeacherDeleteSI.Size = new System.Drawing.Size(84, 36);
            this.btnTeacherDeleteSI.TabIndex = 16;
            this.btnTeacherDeleteSI.Text = "Delete SI";
            this.btnTeacherDeleteSI.UseVisualStyleBackColor = true;
            this.btnTeacherDeleteSI.Click += new System.EventHandler(this.btnTeacherDeleteSI_Click);
            // 
            // btnTeacherUpdate
            // 
            this.btnTeacherUpdate.Location = new System.Drawing.Point(266, 161);
            this.btnTeacherUpdate.Name = "btnTeacherUpdate";
            this.btnTeacherUpdate.Size = new System.Drawing.Size(87, 36);
            this.btnTeacherUpdate.TabIndex = 15;
            this.btnTeacherUpdate.Text = "Update";
            this.btnTeacherUpdate.UseVisualStyleBackColor = true;
            this.btnTeacherUpdate.Click += new System.EventHandler(this.btnTeacherUpdate_Click);
            // 
            // btnTeacherDelete
            // 
            this.btnTeacherDelete.Location = new System.Drawing.Point(160, 161);
            this.btnTeacherDelete.Name = "btnTeacherDelete";
            this.btnTeacherDelete.Size = new System.Drawing.Size(87, 36);
            this.btnTeacherDelete.TabIndex = 14;
            this.btnTeacherDelete.Text = "Delete";
            this.btnTeacherDelete.UseVisualStyleBackColor = true;
            this.btnTeacherDelete.Click += new System.EventHandler(this.btnTeacherDelete_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.Location = new System.Drawing.Point(66, 161);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(88, 36);
            this.btnTeacherAdd.TabIndex = 13;
            this.btnTeacherAdd.Text = "Add";
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // txtTeacherSurname
            // 
            this.txtTeacherSurname.Location = new System.Drawing.Point(160, 94);
            this.txtTeacherSurname.Name = "txtTeacherSurname";
            this.txtTeacherSurname.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherSurname.TabIndex = 12;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(160, 36);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherName.TabIndex = 11;
            // 
            // lblSurnameTeacher
            // 
            this.lblSurnameTeacher.AutoSize = true;
            this.lblSurnameTeacher.Location = new System.Drawing.Point(63, 94);
            this.lblSurnameTeacher.Name = "lblSurnameTeacher";
            this.lblSurnameTeacher.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameTeacher.TabIndex = 10;
            this.lblSurnameTeacher.Text = "Surname";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(63, 36);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(45, 17);
            this.lblTeacherName.TabIndex = 9;
            this.lblTeacherName.Text = "Name";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.btnTeacherDeleteSI);
            this.Controls.Add(this.btnTeacherUpdate);
            this.Controls.Add(this.btnTeacherDelete);
            this.Controls.Add(this.btnTeacherAdd);
            this.Controls.Add(this.txtTeacherSurname);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.lblSurnameTeacher);
            this.Controls.Add(this.lblTeacherName);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTeacher_FormClosing);
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btnTeacherDeleteSI;
        private System.Windows.Forms.Button btnTeacherUpdate;
        private System.Windows.Forms.Button btnTeacherDelete;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.TextBox txtTeacherSurname;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label lblSurnameTeacher;
        private System.Windows.Forms.Label lblTeacherName;
    }
}