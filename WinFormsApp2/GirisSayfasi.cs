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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void buttonGunlukGirdileri_Click(object sender, EventArgs e)
        {
            GunlukGirdiler gunlukGirdiler = new GunlukGirdiler();
            gunlukGirdiler.Show();
            this.Hide();
        }

        private void buttonGununSozu_Click(object sender, EventArgs e)
        {
            GununSozu gununSozu = new GununSozu();
            gununSozu.Show();
            this.Hide();
        }

        private void buttonToDoList_Click(object sender, EventArgs e)
        {
            todolist todolist = new todolist();
            todolist.Show();
            this.Hide();
        }

        private void buttonGunlukSuIcme_Click(object sender, EventArgs e)
        {

        }

        private void buttonGununSarkisi_Click(object sender, EventArgs e)
        {

        }

        private void buttonYemekTakibi_Click(object sender, EventArgs e)
        {

        }

        private void buttonUykuTakibi_Click(object sender, EventArgs e)
        {

        }

        private void buttonFitnessveEgzersizTakibi_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfiliDuzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
