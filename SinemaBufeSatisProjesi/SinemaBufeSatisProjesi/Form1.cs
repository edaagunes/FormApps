using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatisProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasaTutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam
                ;
            misir=Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);

            toplam = misir * 20 + cay * 2 + su * 2 + bilet * 10;
            LblToplam.Text=toplam.ToString() + " TL";

            kasaTutar = kasaTutar + toplam;
            LblKasa.Text = kasaTutar.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
        }
    }
}
