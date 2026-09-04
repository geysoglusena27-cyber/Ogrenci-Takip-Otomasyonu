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
    public partial class FormOdeme : Form
    {
        OleDbConnection baglanti = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OgrenciTakip.accdb");
        public FormOdeme()
        {
            InitializeComponent();
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Odemeler", baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Odemeler (OgrenciID,Tutar,OdemeTarihi)VALUES(?,?,?)", baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrID.Text);
            cmd.Parameters.AddWithValue("?", txtTutar.Text);
            cmd.Parameters.AddWithValue("?", dateOdeme.Value.ToShortDateString());

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ödeme kaydı başarıyla eklendi!");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOdemeID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtOgrID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtTutar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            dateOdeme.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Odemeler SET OgrenciID=?,Tutar=?,OdemeTarihi=? WHERE OdemeID=?"
           , baglanti);

            cmd.Parameters.AddWithValue("?", txtOgrID.Text);
            cmd.Parameters.AddWithValue("?", txtTutar.Text);
            cmd.Parameters.AddWithValue("?", dateOdeme.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("?", txtOdemeID.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ödeme bilgileri güncellendi!");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Odemeler WHERE OdemeID=?", baglanti);

            cmd.Parameters.AddWithValue("?", txtOdemeID.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt silindi");
            listele();
        }
    }
}
