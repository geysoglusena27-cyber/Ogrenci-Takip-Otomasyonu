namespace Öğrenci_Takip_Otomasyonu
{

    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FormOgrenci frm = new FormOgrenci(); frm.Show();
        }


        private void btnDers_Click(object sender, EventArgs e)
        {
            FormDers frm = new FormDers(); frm.Show();
        }

        private void btnDevamsızlık_Click(object sender, EventArgs e)
        {
            FormDevamsızlık frm = new FormDevamsızlık(); frm.Show();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            FormOdeme frm = new FormOdeme(); frm.Show();
        }
        private void btnRapor_Click(object sender, EventArgs e)
        {
            FormRapor frm = new FormRapor(); frm.Show();
        }


        private void btnSonuc_Click_1(object sender, EventArgs e)
        {
            FormDeneme frm = new FormDeneme(); frm.Show();
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            FormAkademik frm = new FormAkademik(); frm.Show();
        }
    }
}





