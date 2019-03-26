namespace CodeFirst_StudentClassroom
{
    partial class FormClassroom
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
            this.txtClassroom = new System.Windows.Forms.TextBox();
            this.btnClassroomAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClassroom = new System.Windows.Forms.DataGridView();
            this.btnClassroomDelete = new System.Windows.Forms.Button();
            this.btnClassroomUpdate = new System.Windows.Forms.Button();
            this.btnClassroomDeleteSI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClassroom
            // 
            this.txtClassroom.Location = new System.Drawing.Point(198, 77);
            this.txtClassroom.Name = "txtClassroom";
            this.txtClassroom.Size = new System.Drawing.Size(100, 20);
            this.txtClassroom.TabIndex = 0;
            // 
            // btnClassroomAdd
            // 
            this.btnClassroomAdd.Location = new System.Drawing.Point(349, 77);
            this.btnClassroomAdd.Name = "btnClassroomAdd";
            this.btnClassroomAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClassroomAdd.TabIndex = 1;
            this.btnClassroomAdd.Text = "Add";
            this.btnClassroomAdd.UseVisualStyleBackColor = true;
            this.btnClassroomAdd.Click += new System.EventHandler(this.btnClassroomAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // dgvClassroom
            // 
            this.dgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassroom.Location = new System.Drawing.Point(134, 191);
            this.dgvClassroom.Name = "dgvClassroom";
            this.dgvClassroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassroom.Size = new System.Drawing.Size(240, 150);
            this.dgvClassroom.TabIndex = 3;
            this.dgvClassroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassroom_CellClick);
            // 
            // btnClassroomDelete
            // 
            this.btnClassroomDelete.Location = new System.Drawing.Point(349, 106);
            this.btnClassroomDelete.Name = "btnClassroomDelete";
            this.btnClassroomDelete.Size = new System.Drawing.Size(75, 23);
            this.btnClassroomDelete.TabIndex = 4;
            this.btnClassroomDelete.Text = "Delete";
            this.btnClassroomDelete.UseVisualStyleBackColor = true;
            this.btnClassroomDelete.Click += new System.EventHandler(this.btnClassroomDelete_Click);
            // 
            // btnClassroomUpdate
            // 
            this.btnClassroomUpdate.Location = new System.Drawing.Point(349, 135);
            this.btnClassroomUpdate.Name = "btnClassroomUpdate";
            this.btnClassroomUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnClassroomUpdate.TabIndex = 5;
            this.btnClassroomUpdate.Text = "Update";
            this.btnClassroomUpdate.UseVisualStyleBackColor = true;
            this.btnClassroomUpdate.Click += new System.EventHandler(this.btnClassroomUpdate_Click);
            // 
            // btnClassroomDeleteSI
            // 
            this.btnClassroomDeleteSI.Location = new System.Drawing.Point(349, 162);
            this.btnClassroomDeleteSI.Name = "btnClassroomDeleteSI";
            this.btnClassroomDeleteSI.Size = new System.Drawing.Size(75, 23);
            this.btnClassroomDeleteSI.TabIndex = 6;
            this.btnClassroomDeleteSI.Text = "Delete SI";
            this.btnClassroomDeleteSI.UseVisualStyleBackColor = true;
            this.btnClassroomDeleteSI.Click += new System.EventHandler(this.btnClassroomDeleteSI_Click);
            // 
            // FormClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClassroomDeleteSI);
            this.Controls.Add(this.btnClassroomUpdate);
            this.Controls.Add(this.btnClassroomDelete);
            this.Controls.Add(this.dgvClassroom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClassroomAdd);
            this.Controls.Add(this.txtClassroom);
            this.Name = "FormClassroom";
            this.Text = "FormClassroom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClassroom_FormClosing);
            this.Load += new System.EventHandler(this.FormClassroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassroom;
        private System.Windows.Forms.Button btnClassroomAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClassroom;
        private System.Windows.Forms.Button btnClassroomDelete;
        private System.Windows.Forms.Button btnClassroomUpdate;
        private System.Windows.Forms.Button btnClassroomDeleteSI;
    }
}