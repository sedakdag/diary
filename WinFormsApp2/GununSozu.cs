using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class GununSozu : Form
    {
        private string ruhHali = "Mutlu"; //Varsayilan Mod
        public GununSozu()
        {
            InitializeComponent();
        }

        private async void GununSozu_Load(object sender, EventArgs e)
        {
           
        }

        private async Task RastgeleSozGoster(string mod)
        {
            string apiUrl = "https://zenquotes.io/api/random";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode) // API'den başarılı bir yanıt geldiyse
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        // JSON'dan söz ve yazarı ayrıştırır
                        var sözListesi = System.Text.Json.JsonDocument.Parse(json).RootElement;
                        var söz = sözListesi[0].GetProperty("q").GetString();
                        var yazar = sözListesi[0].GetProperty("a").GetString();

                        // Modlara göre filtreleme
                        string uygunSöz = SozFiltrele(mod, söz);

                        // Söz ve yazarı ekrana yazdırır
                        labelSoz.Text = $"\"{uygunSöz}\"";
                        labelYazar.Text = $"- {yazar}";

                        labelYazar.TextAlign = ContentAlignment.MiddleCenter;
                        labelSoz.AutoSize = false;
                        labelSoz.Size = new Size(400, 120);
                        labelSoz.TextAlign = ContentAlignment.MiddleCenter;
                        labelSoz.MaximumSize = new Size(600, 200); // Maksimum metin boyutu sınırlar
                        labelSoz.MinimumSize = new Size(600, 200); // Minimum metin boyutu sınırlar
                    }
                    else
                    {
                        labelSoz.Text = "Söz yüklenirken bir hata oluştu.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi verir
                labelSoz.Text = "API'ye bağlanırken bir hata oluştu.";
                MessageBox.Show($"Hata Detayı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SozFiltrele(string mod, string söz)
        {
            // Moda göre filtreleme yapar
            var mutluKelimeler = new List<string> { "happy", "joy", "smile", "positive", "bright" };
            var üzgünKelimeler = new List<string> { "sad", "tears", "pain", "hurt", "dark" };
            var kızgınKelimeler = new List<string> { "anger", "mad", "rage", "fury", "upset" };
            var şaşkınKelimeler = new List<string> { "surprise", "wonder", "awe", "shock", "astonish" };

            // Belirli kelimelere göre sözler filtreler
            var kelimeHavuzu = mod switch
            {
                "Mutlu" => mutluKelimeler,
                "Üzgün" => üzgünKelimeler,
                "Kızgın" => kızgınKelimeler,
                "Şaşkın" => şaşkınKelimeler,
                _ => mutluKelimeler // Varsayılan olarak mutlu sözler döndürür
            };

            foreach (var kelime in kelimeHavuzu)
            {
                if (söz.Contains(kelime, StringComparison.OrdinalIgnoreCase))
                {
                    return söz; // Uygun bir söz bulundu
                }
            }

            return söz; // Eğer mod ile eşleşen bir şey bulunmazsa varsayılan sözü döndürür
        }

        private async void buttonSozuGetir_Click(object sender, EventArgs e)
        {
            string ruhHali = "";

            //Kullanıcının seçtiği checkbox kontrol et
            if (checkMutlu.Checked) ruhHali = "Mutlu";
            else if (checkUzgun.Checked) ruhHali = "Üzgün";
            else if (checkSaskin.Checked) ruhHali = "Şaşkın";
            else if (checkKizgin.Checked) ruhHali = "Kızgın";

            if (!string.IsNullOrEmpty(ruhHali)) // Eğer bir ruh hali seçilmişse
            {
                await RastgeleSozGoster(ruhHali); // Yeni moda göre rastgele söz gösterir
            }
            else
            {
                MessageBox.Show("Lütfen bir ruh hali seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
