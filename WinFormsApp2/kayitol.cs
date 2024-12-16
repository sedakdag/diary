using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class kayitol : Form
    {
        private System.Windows.Forms.Label lblAdBilgi;
        public string Ad { get; private set; }
        public string Soyad { get; private set; }
        public string Email { get; private set; }
        public string KullaniciAdi { get; private set; }
        public int Sifre { get; private set; }

        public kayitol()
        {
            InitializeComponent();
        }

        private object GetTxtAd()
        {
            return txtAd; // txtAd bir TextBox kontrolü.
        }


        public kayitol(IContainer components, TextBox txtAd, TextBox txtSoyad, TextBox txtEmail, TextBox txtKullaniciAdi, TextBox txtSifre, Button btnKaydet, string ad, string soyad, string email, string kullaniciAdi, int sifre)
        {
            this.components = components;
            this.txtAd = txtAd;
            this.txtSoyad = txtSoyad;
            this.txtEmail = txtEmail;
            this.txtKullaniciAdi = txtKullaniciAdi;
            this.txtSifre = txtSifre;
            this.btnKaydet = btnKaydet;
            Ad = ad;
            Soyad = soyad;
            Email = email;
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Girdi doğrulaması
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            if (!int.TryParse(txtSifre.Text, out int sifre))
            {
                MessageBox.Show("Şifre sadece sayılardan oluşmalıdır!");
                return;
            }

            // Değerleri sakla
            Ad = txtAd.Text.Trim();
            Soyad = txtSoyad.Text.Trim();
            Email = txtEmail.Text.Trim();
            KullaniciAdi = txtKullaniciAdi.Text.Trim();
            Sifre = sifre;

            // Formu kapat ve başarıyla kaydet
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
