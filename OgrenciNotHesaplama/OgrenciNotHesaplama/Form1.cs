using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int sinav1, sinav2, proje;
            double sonuc;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            sinav1 = Convert.ToInt16(textBox3.Text);
            sinav2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);

            sonuc = (sinav1 + sinav2 + proje) / 3;

            listBox1.Items.Add("Öğrenci Ad Soyad: " + ad + " " + soyad + " " + "Not Ortalaması: " + sonuc);
        }
    }
}
