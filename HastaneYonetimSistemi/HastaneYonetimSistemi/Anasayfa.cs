using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimSistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            HastaGirisFormu hastaGirisFormu = new HastaGirisFormu();
            hastaGirisFormu.Show();
            this.Hide();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            DoktorGirisFormu doktorGirisFormu = new DoktorGirisFormu();
            doktorGirisFormu.Show();
            this.Hide();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            SekreterGirisFormu sekreterGirisFormu= new SekreterGirisFormu();
            sekreterGirisFormu.Show();
            this.Hide();
        }
    }
}
