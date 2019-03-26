namespace CodeFirst_MToMRelation
{
    partial class FormStart
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmDefinitions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTandS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDefinitions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmDefinitions
            // 
            this.tsmDefinitions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTeacher,
            this.tsmStudent,
            this.tsmTandS});
            this.tsmDefinitions.Name = "tsmDefinitions";
            this.tsmDefinitions.Size = new System.Drawing.Size(93, 24);
            this.tsmDefinitions.Text = "Definitions";
            // 
            // tsmTeacher
            // 
            this.tsmTeacher.Name = "tsmTeacher";
            this.tsmTeacher.Size = new System.Drawing.Size(221, 26);
            this.tsmTeacher.Text = "Teacher";
            this.tsmTeacher.Click += new System.EventHandler(this.tsmTeacher_Click);
            // 
            // tsmStudent
            // 
            this.tsmStudent.Name = "tsmStudent";
            this.tsmStudent.Size = new System.Drawing.Size(221, 26);
            this.tsmStudent.Text = "Student";
            this.tsmStudent.Click += new System.EventHandler(this.tsmStudent_Click);
            // 
            // tsmTandS
            // 
            this.tsmTandS.Name = "tsmTandS";
            this.tsmTandS.Size = new System.Drawing.Size(221, 26);
            this.tsmTandS.Text = "Student And Teacher";
            this.tsmTandS.Click += new System.EventHandler(this.tsmTandS_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormStart";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStart_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDefinitions;
        private System.Windows.Forms.ToolStripMenuItem tsmTeacher;
        private System.Windows.Forms.ToolStripMenuItem tsmStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmTandS;
    }
}

