
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsApp2.MODEL;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<ki�i> ki�ilerim = new List<ki�i>();
        public Form1()
        {
            InitializeComponent();
        }


        private void buttongrs_Click_1(object sender, EventArgs e)
        {
            string kullan�c�adi = "";
            int sifre;
            kullan�c�adi = textBoxkullan�c�.Text;
            sifre = Convert.ToInt32( textBoxsifre.Text);
            foreach(ki�i Ki�i in ki�ilerim)
            {
                if(kullan�c�adi.ToLower()==Ki�i.getkulisim() && sifre==Ki�i.getkul�ifre())
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
            ki�ilerim.Add(new ki�i(1, "s�la", 123, "sila@gmail.com"));
            ki�ilerim.Add(new ki�i(2,"seda" ,456, "seda@gmail.com"));
            ki�ilerim.Add(new ki�i(3, "dilara", 789, "dilara@gmail.com"));
            ki�ilerim.Add(new ki�i(4, "yaprak", 101, "yaprak@gmail.com"));
        }
    }
}
