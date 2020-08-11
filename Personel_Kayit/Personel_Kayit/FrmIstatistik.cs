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

namespace Personel_Kayit
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE2NQQH\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {

            //Toplam Personel Sayısı
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while(dr1.Read())
            {
                lblTplamPersonel.Text = dr1[0].ToString();  
            }


            baglanti.Close();

            //Evli Personel Sayısı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while(dr2.Read())
            {
                lblEvliPersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();
            //Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while(dr3.Read())
            {
                lblBekarPersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();
            // Şehir Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblSehirSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();
            //Toplam Maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();
            //Ortalama Maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read())
            {
                lblOrtalamaMaas.Text = dr6[0].ToString();

            }
            baglanti.Close();
        }
    }
}
