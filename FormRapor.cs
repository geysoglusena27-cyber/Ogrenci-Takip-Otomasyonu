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
    public partial class FormRapor : Form
    {
        OleDbConnection baglanti = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OgrenciTakip.accdb");
        public FormRapor()
        {
            InitializeComponent();
        }

        private void FormRapor_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Ogrenciler", baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnOdemeRaporu_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable(); string sorgu = "SELECT Ogrenciler.Ad,Ogrenciler.Soyad,Odemeler.Tutar,Odemeler.OdemeTarihi " +
                "FROM Odemeler INNER JOIN Ogrenciler ON Odemeler.OgrenciID=Ogrenciler.OgrenciID";

            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            OleDbCommand cmdtoplam = new OleDbCommand("SELECT SUM (Tutar) FROM Odemeler", baglanti);
            object sonuc = cmdtoplam.ExecuteScalar(); decimal toplam = (sonuc != DBNull.Value) ? Convert.ToDecimal(sonuc) : 0;
            lblToplam.Text = "toplam: " + toplam.ToString("C2");
            baglanti.Close();
        }

        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT OgrenciID,Ad,Soyad,Telefon FROM Ogrenciler";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;

            baglanti.Close();

        }
    }
}
