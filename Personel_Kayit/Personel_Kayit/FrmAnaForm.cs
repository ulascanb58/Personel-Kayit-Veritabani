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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE2NQQH\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtMeslek.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();
            

            baglanti.Close();
            MessageBox.Show("Personel Eklendi"); 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            cmbSehir.Text= dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid= @k1",baglanti);

            komutsil.Parameters.AddWithValue("@k1", txtId.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Tamamlandı ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd = @c1, PerSoyad = @c2, PerSehir = @c3, PerMaas = @c4, PerDurum = @c5, PerMeslek = @c6 where Perid =@c7", baglanti);

            komutguncelle.Parameters.AddWithValue("@c1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@c2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@c3", cmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@c4", mskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@c5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@c6", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@c7", txtId.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Personel Bilgi Güncellendi");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
