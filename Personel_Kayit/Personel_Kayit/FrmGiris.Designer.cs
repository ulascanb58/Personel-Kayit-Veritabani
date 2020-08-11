namespace Personel_Kayit
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(375, 178);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(210, 36);
            this.txtKullaniciAd.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(375, 235);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(210, 36);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(375, 298);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(210, 57);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 121);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(787, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(5, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 60);
            this.panel2.TabIndex = 8;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}