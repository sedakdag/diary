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
    }
}
