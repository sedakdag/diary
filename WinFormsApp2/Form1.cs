
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsApp2.MODEL;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        public Form1()
        {
            InitializeComponent();
        }


        private void buttongrs_Click_1(object sender, EventArgs e)
        {
            string kullanıcıadı = "";

            int sifre;
            kullanıcıadı = textBoxkullanıcı.Text;
            sifre = Convert.ToInt32( textBoxsifre.Text);
            foreach(kisi kisi in kisilerim)
            {
                if(kullanıcıadı.ToLower()== kisi.getkulisim() && sifre== kisi.getkulsifre())
                {
                    GirisSayfasi girisSayfasi = new GirisSayfasi();
                    girisSayfasi.Show();
                    this.Hide();
                }
            }
        }

        private void buttonkyt_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1, "sıla", 123, "sila@gmail.com"));
            kisilerim.Add(new kisi(2,"seda" ,456, "seda@gmail.com"));
            kisilerim.Add(new kisi(3, "dilara", 789, "dilara@gmail.com"));
            kisilerim.Add(new kisi(4, "yaprak", 101, "yaprak@gmail.com"));
        }
    }
}
