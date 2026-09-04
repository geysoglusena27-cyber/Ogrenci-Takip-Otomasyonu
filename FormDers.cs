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
    public partial class FormDers : Form
    {
        OleDbConnection baglanti = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OgrenciTakip.accdb");
        public FormDers()
        {
            InitializeComponent();
        }

        private void FormDers_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Dersler", baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Dersler (OgrenciID,OgretmenID,DersKonusu,DersTarihi)VALUES(?,?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrID.Text);
            cmd.Parameters.AddWithValue("?", txtOgrtID.Text);
            cmd.Parameters.AddWithValue("?", txtKonu.Text);
            cmd.Parameters.AddWithValue("?", dateDers.Value.ToShortDateString());

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders eklendi!");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtOgrID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtOgrtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            txtKonu.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
            dateDers.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

        }
       
        
   
       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Dersler SET OgrenciID=?,OgretmenID=?,DersKonusu=?,DersTarihi=? WHERE DersID=?"
           , baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrID.Text);
            cmd.Parameters.AddWithValue("?", txtOgrtID.Text);
            cmd.Parameters.AddWithValue("?", txtKonu.Text);
            cmd.Parameters.AddWithValue("?", dateDers.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("?", txtDersID.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi!");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Dersler WHERE DersID=?",
                baglanti);

            cmd.Parameters.AddWithValue("?",txtDersID.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt başarıyla silindi");
            listele();
        }
    }
}
