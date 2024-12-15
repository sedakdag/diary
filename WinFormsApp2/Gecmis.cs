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
    public partial class Gecmis : Form
    {
        public Gecmis()
        {
            InitializeComponent();
        }

        private void Gecmis_Load(object sender, EventArgs e)
        {
            string dosyaYolu = "girdiler.txt";

            if (!File.Exists(dosyaYolu)) //Eğer girdiler.txt dosyası henüz oluşmadıysa
            {
                MessageBox.Show("Henüz kaydedilmiş bir günlük bulunmuyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            string[] tumGirdiler = File.ReadAllLines(dosyaYolu); //Dosyadaki tüm satırları okur

            int yKoordinat = 10; //İlk girdinin Y koordinatı
            foreach(string girdi in tumGirdiler)
            {
                //Daha estetik bir görüntü için tarih, ruh hali ve günlük aktiviteleri ayırır
                string[] parcalar = girdi.Split(new[] { ':' }, 2); //"Tarih - Ruh Hali \n Günlük Aktivite" şeklinde ayırır
                if (parcalar.Length < 2) //Geçersiz satırları atlar
                {
                    continue;
                }

                string tarih_RuhHali = parcalar[0]; //"Tarih - Ruh Hali"
                string gunlukAktivite = parcalar[1]; //"Günlük Aktivite"

                Label labelTarih = new Label
                {
                    Text = tarih_RuhHali,
                    AutoSize = true,
                    Font = new System.Drawing.Font()
                }



            }




        }
    }
}
