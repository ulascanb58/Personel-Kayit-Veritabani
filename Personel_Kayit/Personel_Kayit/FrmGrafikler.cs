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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE2NQQH\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {

            // Grafik1
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir, count(*) from Tbl_Personel Group By PerSehir", baglanti);

            SqlDataReader dr1 = komutg1.ExecuteReader();

            while(dr1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr1[0], dr1[1]);
            }

            baglanti.Close();

            // Grafik2

            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek, avg(PerMaas) From Tbl_Personel Group by PerMeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while(dr2.Read())
            {
                chart2.Series["Meslek - Maaş"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
            //Grafik3
            baglanti.Open();
            SqlCommand komutg3 = new SqlCommand("Select PerDurum, count(PerDurum) From Tbl_Personel Group By PerDurum", baglanti);
            SqlDataReader dr3 = komutg3.ExecuteReader();
            while(dr3.Read())
            {
                chart3.Series["Evli - Bekar"].Points.AddXY(dr3[0], dr3[1]);
            }
            baglanti.Close();
        }
    }
}
