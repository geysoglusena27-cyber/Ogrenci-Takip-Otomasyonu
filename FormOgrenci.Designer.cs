namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormOgrenci
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
            label2 = new Label();
            label3 = new Label();
            txtOgrenciNo = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            txtTelefon = new TextBox();
            txtAra = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 38);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 66);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // txtOgrenciNo
            // 
            txtOgrenciNo.Location = new Point(89, 1);
            txtOgrenciNo.Name = "txtOgrenciNo";
            txtOgrenciNo.Size = new Size(198, 23);
            txtOgrenciNo.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(89, 35);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(198, 23);
            txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(89, 63);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(198, 23);
            txtSoyad.TabIndex = 9;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 159);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(114, 159);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(215, 159);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(316, 159);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 13;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 150);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 95);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 15;
            label4.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(92, 92);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(198, 23);
            txtTelefon.TabIndex = 16;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(89, 121);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(198, 23);
            txtAra.TabIndex = 17;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 129);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 18;
            label5.Text = "Öğrenci Ara:";
            // 
            // FormOgrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 350);
            Controls.Add(label5);
            Controls.Add(txtAra);
            Controls.Add(txtTelefon);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtOgrenciNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormOgrenci";
            Text = "FormOgrenci";
            Load += FormOgrenci_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTelefon;
        private TextBox textBox2;
        private Button btnSil;
        private TextBox txtSoyad;
        private TextBox txtOgrenciNo;
        private TextBox txtAd;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnListele;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtAra;
        private Label label5;
    }
}