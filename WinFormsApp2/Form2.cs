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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonprofil_Click(object sender, EventArgs e)
        {

        }



        private void buttongunlukgırdı_Click(object sender, EventArgs e)
        {
            GunlukGirdiler gunlukGirdiler = new GunlukGirdiler();
            gunlukGirdiler.Show();
            this.Hide();
        }

        private void buttongununsozu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GunlukGirdiler gunlukGirdiler = new GunlukGirdiler();
            gunlukGirdiler.Show();
            this.Hide();
        }
    }
}
