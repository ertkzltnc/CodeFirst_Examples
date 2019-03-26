namespace codeFirstLogin
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
            this.grbGiris = new System.Windows.Forms.GroupBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.grbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGiris
            // 
            this.grbGiris.Controls.Add(this.label2);
            this.grbGiris.Controls.Add(this.label1);
            this.grbGiris.Controls.Add(this.txtSifre);
            this.grbGiris.Controls.Add(this.btnGiris);
            this.grbGiris.Controls.Add(this.txtKullanici);
            this.grbGiris.Location = new System.Drawing.Point(188, 38);
            this.grbGiris.Name = "grbGiris";
            this.grbGiris.Size = new System.Drawing.Size(306, 189);
            this.grbGiris.TabIndex = 0;
            this.grbGiris.TabStop = false;
            this.grbGiris.Text = "Hos Geldiniz";
            this.grbGiris.Enter += new System.EventHandler(this.grbGiris_Enter);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(86, 39);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 20);
            this.txtKullanici.TabIndex = 0;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(86, 110);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 23);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(86, 75);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(194, 230);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 416);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.grbGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbGiris.ResumeLayout(false);
            this.grbGiris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSonuc;
    }
}

