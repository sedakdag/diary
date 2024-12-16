namespace WinFormsApp2
{
    partial class kayitol
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

        // Alan adlarını benzersiz yapıyoruz.
        private System.Windows.Forms.Label _lblAdBilgi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKaydet;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _lblAdBilgi = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // _lblAdBilgi
            // 
            _lblAdBilgi.Location = new Point(15, 47);
            _lblAdBilgi.Margin = new Padding(4, 0, 4, 0);
            _lblAdBilgi.Name = "_lblAdBilgi";
            _lblAdBilgi.Size = new Size(140, 26);
            _lblAdBilgi.TabIndex = 0;
            _lblAdBilgi.Text = "Adınızı girin";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(195, 47);
            txtAd.Margin = new Padding(4, 4, 4, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(127, 25);
            txtAd.TabIndex = 0;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(195, 90);
            txtSoyad.Margin = new Padding(4, 4, 4, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(127, 25);
            txtSoyad.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(195, 136);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(127, 25);
            txtEmail.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(195, 180);
            txtKullaniciAdi.Margin = new Padding(4, 4, 4, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(127, 25);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(195, 230);
            txtSifre.Margin = new Padding(4, 4, 4, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(127, 25);
            txtSifre.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Thistle;
            btnKaydet.Location = new Point(212, 281);
            btnKaydet.Margin = new Padding(4, 4, 4, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(96, 26);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 6;
            label1.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 6;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 6;
            label3.Text = "Kullanıcı adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 230);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 6;
            label4.Text = "Şifre";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(458, 353);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_lblAdBilgi);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtEmail);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(btnKaydet);
            Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtAd.Text))
            {
                this._lblAdBilgi.Text = "Ad alanı boş olamaz!";
                this._lblAdBilgi.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this._lblAdBilgi.Text = $"Merhaba, {this.txtAd.Text}";
                this._lblAdBilgi.ForeColor = System.Drawing.Color.Green;
            }
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
