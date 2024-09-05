using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYonetimSistemi
{
    public partial class DoktorDetayFormu : Form
    {
        public DoktorDetayFormu()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();
        public string TC;
        private void DoktorDetayFormu_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            // Doktor AD SOYAD çekme
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            // Randevu listesi getirme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor ='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenleFormu doktorBilgiDuzenleFormu = new DoktorBilgiDuzenleFormu();
            doktorBilgiDuzenleFormu.TCNO = LblTC.Text;
            doktorBilgiDuzenleFormu.Show();

        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            DuyurularFormu duyurularFormu = new DuyurularFormu();
            duyurularFormu.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            
        }
    }
}
