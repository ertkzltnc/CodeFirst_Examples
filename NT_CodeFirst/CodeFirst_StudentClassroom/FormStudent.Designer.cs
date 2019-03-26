namespace CodeFirst_StudentClassroom
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cbClassroom = new System.Windows.Forms.ComboBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentDeleteSI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(138, 223);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(240, 150);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(181, 77);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // cbClassroom
            // 
            this.cbClassroom.FormattingEnabled = true;
            this.cbClassroom.Location = new System.Drawing.Point(181, 119);
            this.cbClassroom.Name = "cbClassroom";
            this.cbClassroom.Size = new System.Drawing.Size(121, 21);
            this.cbClassroom.TabIndex = 2;
            this.cbClassroom.TextChanged += new System.EventHandler(this.cbClassroom_TextChanged);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(181, 170);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 3;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FullName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Classroom";
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(375, 170);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStudentUpdate.TabIndex = 7;
            this.btnStudentUpdate.Text = "Update";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(280, 170);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 6;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentDeleteSI
            // 
            this.btnStudentDeleteSI.Location = new System.Drawing.Point(482, 169);
            this.btnStudentDeleteSI.Name = "btnStudentDeleteSI";
            this.btnStudentDeleteSI.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDeleteSI.TabIndex = 8;
            this.btnStudentDeleteSI.Text = "Delete SI";
            this.btnStudentDeleteSI.UseVisualStyleBackColor = true;
            this.btnStudentDeleteSI.Click += new System.EventHandler(this.btnStudentDeleteSI_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudentDeleteSI);
            this.Controls.Add(this.btnStudentUpdate);
            this.Controls.Add(this.btnStudentDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.cbClassroom);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.dgvStudent);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudent_FormClosing);
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cbClassroom;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentDeleteSI;
    }
}