
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
            // Veritaban� ba�lant� dizgisini sabit olarak tutmak yerine, yap�land�rma dosyas�ndan almak daha iyi bir y�ntemdir.
            private static readonly string connectionString = "Data Source=DESKTOP-CQ34R50\\MSSQLSERVER01;Initial Catalog=kullan�c�lar;Integrated Security=True;Encrypt=False";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void buttonkyt_Click(object sender, EventArgs e)
        {
            // Kay�t i�lemi i�in gerekli kod burada yaz�labilir.
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            string kulad = textBoxkullan�c�.Text.Trim();
            string kul�ifre = textBoxsifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kulad) || string.IsNullOrWhiteSpace(kul�ifre))
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� olamaz.");
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Parametreli sorgu ile SQL enjeksiyonu �nlenir.
                    string query = "SELECT kulid FROM users WHERE kulad = @kulad AND kul�ifre = @kul�ifre";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kulad", kulad);
                        command.Parameters.AddWithValue("@kul�ifre", kul�ifre);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int kulid = Convert.ToInt32(result);
                            MessageBox.Show($"Giri� ba�ar�l�! Kullan�c� ID: {kulid}");

                            // Kullan�c�y� ba�ka bir forma y�nlendirme i�lemi yap�labilir.
                            // �rne�in: new ProfileForm().Show(); this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Giri� ba�ar�s�z. Kullan�c� ad� veya �ifre yanl��.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj g�r�nt�lenir.
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}");
            }
        }
    }
}

