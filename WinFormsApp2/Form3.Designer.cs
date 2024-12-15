

namespace WinFormsApp2
{
    partial class Form3
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
        private void InitializeComponent(object v)
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(107, 43);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(107, 92);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(107, 235);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(107, 308);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(107, 368);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(btnKaydet);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKaydet;
    }
}
