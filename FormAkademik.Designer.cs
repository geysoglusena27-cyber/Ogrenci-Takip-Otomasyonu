namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormAkademik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtDurum = new TextBox();
            label2 = new Label();
            txtOgrenci = new TextBox();
            label3 = new Label();
            txtOrtalama = new TextBox();
            txtSeviye = new TextBox();
            label4 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "DurumID";
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(72, 5);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(100, 23);
            txtDurum.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "OgrenciID";
            // 
            // txtOgrenci
            // 
            txtOgrenci.Location = new Point(72, 34);
            txtOgrenci.Name = "txtOgrenci";
            txtOgrenci.Size = new Size(100, 23);
            txtOgrenci.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 71);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Ortalama";
            // 
            // txtOrtalama
            // 
            txtOrtalama.Location = new Point(73, 63);
            txtOrtalama.Name = "txtOrtalama";
            txtOrtalama.Size = new Size(100, 23);
            txtOrtalama.TabIndex = 5;
            // 
            // txtSeviye
            // 
            txtSeviye.Location = new Point(72, 92);
            txtSeviye.Name = "txtSeviye";
            txtSeviye.Size = new Size(100, 23);
            txtSeviye.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 100);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Seviye";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(16, 140);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(111, 140);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(218, 140);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(326, 140);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 17;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 154);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormAkademik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(label4);
            Controls.Add(txtSeviye);
            Controls.Add(txtOrtalama);
            Controls.Add(label3);
            Controls.Add(txtOgrenci);
            Controls.Add(label2);
            Controls.Add(txtDurum);
            Controls.Add(label1);
            Name = "FormAkademik";
            Text = "FormAkademik";
            Load += FormAkademik_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDurum;
        private Label label2;
        private TextBox txtOgrenci;
        private Label label3;
        private TextBox txtOrtalama;
        private TextBox txtSeviye;
        private Label label4;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private DataGridView dataGridView1;
    }
}