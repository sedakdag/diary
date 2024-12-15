using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinFormsApp2.MODEL;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        string filePath = "kullaniciBilgileri.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttongrs_Click_1(object sender, EventArgs e)
        {
            string kullaniciadi = textBoxkullanici.Text;
            int sifre;

            if (int.TryParse(textBoxsifre.Text, out sifre))
            {
                foreach (kisi kisi in kisilerim)
                {
                    if (kullaniciadi.ToLower() == kisi.getkulisim() && sifre == kisi.getkulsifre())
                    {
                        GirisSayfasi form2 = new GirisSayfasi();
                        form2.Show();
                        this.Hide();
                        return;
                    }
                }

                // Txt dosyasýndan kontrol et
                if (ValidateLogin(kullaniciadi, sifre))
                {
                    GirisSayfasi form2 = new GirisSayfasi();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir şifre giriniz!");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Önceden tanýmlý kullanýcýlar
            kisilerim.Add(new kisi(1, "sýla", 123, "sila@gmail.com"));
            kisilerim.Add(new kisi(2, "seda", 456, "seda@gmail.com"));
            kisilerim.Add(new kisi(3, "dilara", 789, "dilara@gmail.com"));
            kisilerim.Add(new kisi(4, "yaprak", 101, "yaprak@gmail.com"));

            // Txt dosyasýndan kullanýcýlarý yükle
            LoadUsersFromFile();
        }

        private void LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length == 2)
                    {
                        string username = data[0];
                        if (int.TryParse(data[1], out int password))
                        {
                            kisilerim.Add(new kisi(kisilerim.Count + 1, username, password, ""));
                        }
                    }
                }
            }
        }

        private bool CheckIfUserExists(string username)
        {
            if (!File.Exists(filePath)) return false;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var data = line.Split(';');
                if (data[0].ToLower() == username.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateLogin(string username, int password)
        {
            if (!File.Exists(filePath)) return false;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var data = line.Split(';');
                if (data[0].ToLower() == username.ToLower() && int.TryParse(data[1], out int storedPassword) && storedPassword == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonKyt_Click(object sender, EventArgs e)
        {
            // Yeni bir Form3 örneği oluştur
            Form3 form3 = new Form3();

            // Formu göster ve sonucu kontrol et
            if (form3.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcı bilgilerini al
                string ad = form3.Ad;
                string soyad = form3.Soyad;
                string email = form3.Email;
                string kullaniciAdi = form3.KullaniciAdi;
                int sifre = form3.Sifre;

                // Kullanıcı adı tekrar kontrolü
                if (kişilerim.Exists(k => k.getkulisim() == kullaniciAdi))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kayıtlı!");
                    return;
                }

                // Yeni kullanıcıyı ekle
                kişilerim.Add(new kişi(kişilerim.Count + 1, kullaniciAdi, sifre, email));
                File.AppendAllText(filePath, $"{kullaniciAdi};{sifre}{Environment.NewLine}");
                MessageBox.Show("Kayıt başarıyla tamamlandı!");
            }
        }
    }
}
