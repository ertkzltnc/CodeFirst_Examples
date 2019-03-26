namespace CodeFirst_MToMRelation
{
    partial class FormRelationship
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
            this.lblRelation = new System.Windows.Forms.Label();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.dgvRelationship = new System.Windows.Forms.DataGridView();
            this.btnRelationshipDeleteSI = new System.Windows.Forms.Button();
            this.btnRelationshipDelete = new System.Windows.Forms.Button();
            this.btnRelationshipAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelationship)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelation
            // 
            this.lblRelation.AutoSize = true;
            this.lblRelation.Location = new System.Drawing.Point(28, 24);
            this.lblRelation.Name = "lblRelation";
            this.lblRelation.Size = new System.Drawing.Size(65, 17);
            this.lblRelation.TabIndex = 0;
            this.lblRelation.Text = "Teacher:";
            // 
            // cbTeacher
            // 
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(160, 24);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(204, 24);
            this.cbTeacher.TabIndex = 1;
            this.cbTeacher.TextChanged += new System.EventHandler(this.cbTeacher_TextChanged);
            // 
            // lbStudent
            // 
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.ItemHeight = 16;
            this.lbStudent.Location = new System.Drawing.Point(586, 24);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbStudent.Size = new System.Drawing.Size(202, 372);
            this.lbStudent.TabIndex = 2;
            this.lbStudent.Click += new System.EventHandler(this.lbStudent_Click);
            // 
            // dgvRelationship
            // 
            this.dgvRelationship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelationship.Location = new System.Drawing.Point(31, 106);
            this.dgvRelationship.Name = "dgvRelationship";
            this.dgvRelationship.RowTemplate.Height = 24;
            this.dgvRelationship.Size = new System.Drawing.Size(549, 150);
            this.dgvRelationship.TabIndex = 3;
            this.dgvRelationship.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRelationshipDeleteSI
            // 
            this.btnRelationshipDeleteSI.Location = new System.Drawing.Point(235, 332);
            this.btnRelationshipDeleteSI.Name = "btnRelationshipDeleteSI";
            this.btnRelationshipDeleteSI.Size = new System.Drawing.Size(86, 33);
            this.btnRelationshipDeleteSI.TabIndex = 20;
            this.btnRelationshipDeleteSI.Text = "Delete SI";
            this.btnRelationshipDeleteSI.UseVisualStyleBackColor = true;
            this.btnRelationshipDeleteSI.Click += new System.EventHandler(this.btnRelationshipDeleteSI_Click);
            // 
            // btnRelationshipDelete
            // 
            this.btnRelationshipDelete.Location = new System.Drawing.Point(130, 332);
            this.btnRelationshipDelete.Name = "btnRelationshipDelete";
            this.btnRelationshipDelete.Size = new System.Drawing.Size(84, 33);
            this.btnRelationshipDelete.TabIndex = 18;
            this.btnRelationshipDelete.Text = "Delete";
            this.btnRelationshipDelete.UseVisualStyleBackColor = true;
            this.btnRelationshipDelete.Click += new System.EventHandler(this.btnRelationshipDelete_Click);
            // 
            // btnRelationshipAdd
            // 
            this.btnRelationshipAdd.Location = new System.Drawing.Point(36, 332);
            this.btnRelationshipAdd.Name = "btnRelationshipAdd";
            this.btnRelationshipAdd.Size = new System.Drawing.Size(88, 33);
            this.btnRelationshipAdd.TabIndex = 17;
            this.btnRelationshipAdd.Text = "Add";
            this.btnRelationshipAdd.UseVisualStyleBackColor = true;
            this.btnRelationshipAdd.Click += new System.EventHandler(this.btnRelationshipAdd_Click);
            // 
            // FormRelationship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRelationshipDeleteSI);
            this.Controls.Add(this.btnRelationshipDelete);
            this.Controls.Add(this.btnRelationshipAdd);
            this.Controls.Add(this.dgvRelationship);
            this.Controls.Add(this.lbStudent);
            this.Controls.Add(this.cbTeacher);
            this.Controls.Add(this.lblRelation);
            this.Name = "FormRelationship";
            this.Text = "FormRelationship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRelationship_FormClosing);
            this.Load += new System.EventHandler(this.FormRelationship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelationship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelation;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.ListBox lbStudent;
        private System.Windows.Forms.DataGridView dgvRelationship;
        private System.Windows.Forms.Button btnRelationshipDeleteSI;
        private System.Windows.Forms.Button btnRelationshipDelete;
        private System.Windows.Forms.Button btnRelationshipAdd;
    }
}