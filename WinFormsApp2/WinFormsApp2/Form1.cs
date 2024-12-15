
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class DatabaseHelper
        {
            // Veritabaný baðlantý dizgisini sabit olarak tutmak yerine, yapýlandýrma dosyasýndan almak daha iyi bir yöntemdir.
            private static readonly string connectionString = "Data Source=DESKTOP-CQ34R50\\MSSQLSERVER01;Initial Catalog=kullanýcýlar;Integrated Security=True;Encrypt=False";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void buttonkyt_Click(object sender, EventArgs e)
        {
            // Kayýt iþlemi için gerekli kod burada yazýlabilir.
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            string kulad = textBoxkullanýcý.Text.Trim();
            string kulþifre = textBoxsifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kulad) || string.IsNullOrWhiteSpace(kulþifre))
            {
                MessageBox.Show("Kullanýcý adý ve þifre boþ olamaz.");
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Parametreli sorgu ile SQL enjeksiyonu önlenir.
                    string query = "SELECT kulid FROM users WHERE kulad = @kulad AND kulþifre = @kulþifre";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kulad", kulad);
                        command.Parameters.AddWithValue("@kulþifre", kulþifre);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int kulid = Convert.ToInt32(result);
                            MessageBox.Show($"Giriþ baþarýlý! Kullanýcý ID: {kulid}");

                            // Kullanýcýyý baþka bir forma yönlendirme iþlemi yapýlabilir.
                            // Örneðin: new ProfileForm().Show(); this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Giriþ baþarýsýz. Kullanýcý adý veya þifre yanlýþ.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj görüntülenir.
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
            }
        }
    }
}

