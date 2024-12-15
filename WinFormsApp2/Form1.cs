using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinFormsApp2.MODEL;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<kiþi> kiþilerim = new List<kiþi>();
        string filePath = "kullaniciBilgileri.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttongrs_Click_1(object sender, EventArgs e)
        {
            string kullanýcýadi = textBoxkullanýcý.Text;
            int sifre;

            if (int.TryParse(textBoxsifre.Text, out sifre))
            {
                foreach (kiþi Kiþi in kiþilerim)
                {
                    if (kullanýcýadi.ToLower() == Kiþi.getkulisim() && sifre == Kiþi.getkulþifre())
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                        return;
                    }
                }

                // Txt dosyasýndan kontrol et
                if (ValidateLogin(kullanýcýadi, sifre))
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir þifre giriniz!");
            }
        }


        private void buttonkyt_Click(object sender, EventArgs e)
        {
            // Yeni bir Form3 örneði oluþtur
            Form3 form3 = new Form3();

            // Formu göster ve sonucu kontrol et
            if (form3.ShowDialog() == DialogResult.OK)
            {
                // Kullanýcý bilgilerini al
                string ad = form3.Ad;
                string soyad = form3.Soyad;
                string email = form3.Email;
                string kullaniciAdi = form3.KullaniciAdi;
                int sifre = form3.Sifre;

                // Kullanýcý adý tekrar kontrolü
                if (kiþilerim.Exists(k => k.getkulisim() == kullaniciAdi))
                {
                    MessageBox.Show("Bu kullanýcý adý zaten kayýtlý!");
                    return;
                }

                // Yeni kullanýcýyý ekle
                kiþilerim.Add(new kiþi(kiþilerim.Count + 1, kullaniciAdi, sifre, email));
                File.AppendAllText(filePath, $"{kullaniciAdi};{sifre}{Environment.NewLine}");
                MessageBox.Show("Kayýt baþarýyla tamamlandý!");
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // Önceden tanýmlý kullanýcýlar
            kiþilerim.Add(new kiþi(1, "sýla", 123, "sila@gmail.com"));
            kiþilerim.Add(new kiþi(2, "seda", 456, "seda@gmail.com"));
            kiþilerim.Add(new kiþi(3, "dilara", 789, "dilara@gmail.com"));
            kiþilerim.Add(new kiþi(4, "yaprak", 101, "yaprak@gmail.com"));

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
                            kiþilerim.Add(new kiþi(kiþilerim.Count + 1, username, password, ""));
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
    }
}
