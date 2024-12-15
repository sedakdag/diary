
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsApp2.MODEL;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<kiþi> kiþilerim = new List<kiþi>();
        public Form1()
        {
            InitializeComponent();
        }


        private void buttongrs_Click_1(object sender, EventArgs e)
        {
            string kullanýcýadi = "";
            int sifre;
            kullanýcýadi = textBoxkullanýcý.Text;
            sifre = Convert.ToInt32( textBoxsifre.Text);
            foreach(kiþi Kiþi in kiþilerim)
            {
                if(kullanýcýadi.ToLower()==Kiþi.getkulisim() && sifre==Kiþi.getkulþifre())
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
        }

        private void buttonkyt_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kiþilerim.Add(new kiþi(1, "sýla", 123, "sila@gmail.com"));
            kiþilerim.Add(new kiþi(2,"seda" ,456, "seda@gmail.com"));
            kiþilerim.Add(new kiþi(3, "dilara", 789, "dilara@gmail.com"));
            kiþilerim.Add(new kiþi(4, "yaprak", 101, "yaprak@gmail.com"));
        }
    }
}
