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
    public partial class FormOgrenci : Form
    {
        OleDbConnection baglanti = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OgrenciTakip.accdb");


        public FormOgrenci()
        {
            InitializeComponent();
        }

        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            listele();

        }
        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Ogrenciler", baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Ogrenciler (OgrenciID,Ad,Soyad,Telefon)VALUES(?,?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrenciNo.Text);
            cmd.Parameters.AddWithValue("?", txtAd.Text);
            cmd.Parameters.AddWithValue("?", txtSoyad.Text);
            cmd.Parameters.AddWithValue("?", txtTelefon.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci başarıyla eklendi!");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Ogrenciler SET Ad=?,Soyad=?,Telefon=? WHERE OgrenciID=?"
           , baglanti);

            cmd.Parameters.AddWithValue("?", txtAd.Text);
            cmd.Parameters.AddWithValue("?", txtSoyad.Text);
            cmd.Parameters.AddWithValue("?", txtTelefon.Text);
            cmd.Parameters.AddWithValue("?", txtOgrenciNo.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci başarıyla güncellendi!");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Ogrenciler WHERE OgrenciID=?",
                baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrenciNo.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Öğrenci kaydı silindi");
            listele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Ogrenciler WHERE Ad LIKE @arama OR Soyad LIKE @arama OR Telefon LIKE @arama"
                , baglanti);

            da.SelectCommand.Parameters.AddWithValue("@arama", "%" + txtAra.Text + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


            baglanti.Close();
    }
    }
}

