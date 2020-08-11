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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE2NQQH\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd = @p1 and sifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1" , txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2" , txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKullaniciAd.Text = "";
                txtSifre.Text = "";
                txtKullaniciAd.Focus();
            }
            

            baglanti.Close();
        }
    }
}
