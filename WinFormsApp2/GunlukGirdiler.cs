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
    public partial class GunlukGirdiler : Form
    {
        public GunlukGirdiler()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkboxmutlu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunlukGirdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGecmis_Click(object sender, EventArgs e)
        {
            Gecmis gecmis = new Gecmis();
            gecmis.Show();
            this.Hide();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string tarih = datetime_Picker.Value.ToString("yyyy-MM-dd"); //Kullanıcının seçtiği tarih
            string gunlukAktivite = gunlukGirdi.Text; //Textbox içeriği
            string ruhHali = ""; //Kullanıcının seçtiği mod

            if (checkMutlu.Checked)
            {
                ruhHali = "Mutlu";
            }
            else if (checkNormal.Checked)
            {
                ruhHali = "Normal";
            }
            else if (checkUykulu.Checked)
            {
                ruhHali = "Uykulu";
            }
            else if (checkHasta.Checked)
            {
                ruhHali = "Hasta";
            }
            else if (checkSaskin.Checked)
            {
                ruhHali = "Şaşkın";
            }
            else if (checkUzgun.Checked)
            {
                ruhHali = "Üzgün";
            }

            if ((string.IsNullOrEmpty(gunlukAktivite)) || (string.IsNullOrEmpty(ruhHali)))
            {
                MessageBox.Show("Tüm alanları doldurmadınız veya bir ruh hali seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Kullanıcı günlük girdisini doldurmazsa veya ruh halini seçmezse uyarı
                return;
            }

            //Kullanıcının girdilerini dosyaya yazma

            string dosyaYolu = "girdiler.txt";
            string satir = $"{tarih} - {ruhHali}: {gunlukAktivite}";
            File.AppendAllText(dosyaYolu, satir + Environment.NewLine);

            MessageBox.Show("Günlük başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Bir sonraki girdi için alanları sıfırlama

            gunlukGirdi.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }


        }

        private void GunlukGirdiler_Load(object sender, EventArgs e)
        {

        }


    }
}
