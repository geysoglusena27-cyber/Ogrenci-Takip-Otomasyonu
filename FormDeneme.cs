using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Öğrenci_Takip_Otomasyonu
{
    public partial class FormDeneme : Form
    {
        OleDbConnection baglanti = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OgrenciTakip.accdb");
        public FormDeneme()
        {
            InitializeComponent();
        }

        private void FormDeneme_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Sonuc", baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Sonuc (DenemeID,OgrenciID,Dogru,Yanlis,Net)VALUES(?,?,?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtDeneme.Text);
            cmd.Parameters.AddWithValue("?", txtDers.Text);
            cmd.Parameters.AddWithValue("?", txtDogru.Text);
            cmd.Parameters.AddWithValue("?", txtYanlış.Text);
            cmd.Parameters.AddWithValue("?", txtNet.Text);
            cmd.Parameters.AddWithValue("?", dateDeneme.Value.ToShortDateString());

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Deneme eklendi!");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeneme.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtOgrenci.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtDogru.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            txtYanlış.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
            txtNet.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Sonuc (DenemeID,OgrenciID,Dogru,Yanlis,Net)VALUES(?,?,?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtDeneme.Text);
            cmd.Parameters.AddWithValue("?", txtDers.Text);
            cmd.Parameters.AddWithValue("?", txtDogru.Text);
            cmd.Parameters.AddWithValue("?", txtYanlış.Text);
            cmd.Parameters.AddWithValue("?", txtNet.Text);
            cmd.Parameters.AddWithValue("?", dateDeneme.Value.ToShortDateString());

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi!");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Sonuc WHERE DenemeID=?",
                baglanti);

            cmd.Parameters.AddWithValue("?", txtDeneme.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt silindi");
            listele();
        }
    }
}
