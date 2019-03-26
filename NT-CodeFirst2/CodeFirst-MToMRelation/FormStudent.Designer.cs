namespace CodeFirst_MToMRelation
{
    partial class FormStudent
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblSurnameStudent = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.btnStudenDeleteSI = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(28, 30);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(45, 17);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name";
            // 
            // lblSurnameStudent
            // 
            this.lblSurnameStudent.AutoSize = true;
            this.lblSurnameStudent.Location = new System.Drawing.Point(28, 88);
            this.lblSurnameStudent.Name = "lblSurnameStudent";
            this.lblSurnameStudent.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameStudent.TabIndex = 1;
            this.lblSurnameStudent.Text = "Surname";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(125, 30);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(125, 88);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(100, 22);
            this.txtStudentSurname.TabIndex = 3;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(31, 155);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(88, 35);
            this.btnStudentAdd.TabIndex = 4;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(125, 155);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(85, 35);
            this.btnStudentDelete.TabIndex = 5;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(231, 155);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(87, 35);
            this.btnStudentUpdate.TabIndex = 6;
            this.btnStudentUpdate.Text = "Update";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // btnStudenDeleteSI
            // 
            this.btnStudenDeleteSI.Location = new System.Drawing.Point(324, 155);
            this.btnStudenDeleteSI.Name = "btnStudenDeleteSI";
            this.btnStudenDeleteSI.Size = new System.Drawing.Size(88, 35);
            this.btnStudenDeleteSI.TabIndex = 7;
            this.btnStudenDeleteSI.Text = "Delete SI";
            this.btnStudenDeleteSI.UseVisualStyleBackColor = true;
            this.btnStudenDeleteSI.Click += new System.EventHandler(this.btnStudenDeleteSI_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(31, 216);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(572, 150);
            this.dgvStudent.TabIndex = 8;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnStudenDeleteSI);
            this.Controls.Add(this.btnStudentUpdate);
            this.Controls.Add(this.btnStudentDelete);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblSurnameStudent);
            this.Controls.Add(this.lblStudentName);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudent_FormClosing);
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblSurnameStudent;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Button btnStudenDeleteSI;
        private System.Windows.Forms.DataGridView dgvStudent;
    }
}