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
    public partial class profilsayfasi : Form
    {
        public profilsayfasi()
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
            soz Soz = new soz();
            Soz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            GunlukGirdiler gunlukGirdiler = new GunlukGirdiler();
            gunlukGirdiler.Show();
            this.Hide();
        }

        private void buttontodo_Click(object sender, EventArgs e)
        {
            todolist xtodo = new todolist();
            xtodo.Show();
            this.Hide();
        }
    }
}
