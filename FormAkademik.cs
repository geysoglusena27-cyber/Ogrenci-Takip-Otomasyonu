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
    public partial class FormAkademik : Form
    {
        OleDbConnection baglanti = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OgrenciTakip.accdb");

        public FormAkademik()
        {
            InitializeComponent();
        }



        private void FormAkademik_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Durum", baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Durum (DurumID,OgrenciID,Ortalama,Seviye)VALUES(?,?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtDurum.Text);
            cmd.Parameters.AddWithValue("?", txtOgrenci.Text);
            cmd.Parameters.AddWithValue("?", txtOrtalama.Text);
            cmd.Parameters.AddWithValue("?", txtSeviye.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Durum eklendi!");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtOgrenci.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            txtSeviye.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Durum (DurumID,OgrenciID,Ortalama,Seviye)VALUES(?,?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtDurum.Text);
            cmd.Parameters.AddWithValue("?", txtOgrenci.Text);
            cmd.Parameters.AddWithValue("?", txtOrtalama.Text);
            cmd.Parameters.AddWithValue("?", txtSeviye.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi!");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE Durum (DurumID,OgrenciID,Ortalama,Seviye)VALUES(?,?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtDurum.Text);
            cmd.Parameters.AddWithValue("?", txtOgrenci.Text);
            cmd.Parameters.AddWithValue("?", txtOrtalama.Text);
            cmd.Parameters.AddWithValue("?", txtSeviye.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            listele();
        }
    }
}
