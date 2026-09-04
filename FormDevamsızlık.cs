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
    public partial class FormDevamsızlık : Form
    {
        OleDbConnection baglanti = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OgrenciTakip.accdb");
        public FormDevamsızlık()
        {
            InitializeComponent();
        }

        private void FormDevamsızlık_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Devamsızlık", baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Devamsızlık (OgrenciID,DersID,Tarih)VALUES(?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrenciID.Text);
            cmd.Parameters.AddWithValue("?", txtDersID.Text);
            cmd.Parameters.AddWithValue("?", dateTarih.Value.ToShortDateString());

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Devamsızlık kaydı eklendi!");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtOgrenciID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            dateTarih.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Devamsızlık SET OgrenciID=?,DersID=?,Tarih=? WHERE DevamsızlıkID=?"
           , baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrenciID.Text);
            cmd.Parameters.AddWithValue("?", txtDersID.Text);
            cmd.Parameters.AddWithValue("?", dateTarih.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("?", txtID.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Devamsızlık kaydı başarıyla güncellendi!");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Devamsızlık WHERE DevamsızlıkID=?",
                baglanti);

            cmd.Parameters.AddWithValue("?",txtID.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt başarıyla silindi");
            listele();
        }
    }
}
