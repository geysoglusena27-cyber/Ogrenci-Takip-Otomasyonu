namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormDeneme
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
            txtDeneme = new TextBox();
            label2 = new Label();
            txtOgrenci = new TextBox();
            txtDers = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDogru = new TextBox();
            txtYanlış = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtNet = new TextBox();
            label7 = new Label();
            dateDeneme = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnListele = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "DenemeID";
            // 
            // txtDeneme
            // 
            txtDeneme.Location = new Point(83, 10);
            txtDeneme.Name = "txtDeneme";
            txtDeneme.Size = new Size(100, 23);
            txtDeneme.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 43);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "OgrenciID";
            // 
            // txtOgrenci
            // 
            txtOgrenci.Location = new Point(83, 39);
            txtOgrenci.Name = "txtOgrenci";
            txtOgrenci.Size = new Size(100, 23);
            txtOgrenci.TabIndex = 3;
            // 
            // txtDers
            // 
            txtDers.Location = new Point(83, 68);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(100, 23);
            txtDers.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "DersID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 101);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Doğru";
            // 
            // txtDogru
            // 
            txtDogru.Location = new Point(83, 97);
            txtDogru.Name = "txtDogru";
            txtDogru.Size = new Size(100, 23);
            txtDogru.TabIndex = 7;
            // 
            // txtYanlış
            // 
            txtYanlış.Location = new Point(83, 122);
            txtYanlış.Name = "txtYanlış";
            txtYanlış.Size = new Size(100, 23);
            txtYanlış.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 130);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Yanlış";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 162);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 10;
            label6.Text = "Net";
            // 
            // txtNet
            // 
            txtNet.Location = new Point(83, 151);
            txtNet.Name = "txtNet";
            txtNet.Size = new Size(100, 23);
            txtNet.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 186);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 12;
            label7.Text = "Tarih";
            // 
            // dateDeneme
            // 
            dateDeneme.Location = new Point(83, 180);
            dateDeneme.Name = "dateDeneme";
            dateDeneme.Size = new Size(200, 23);
            dateDeneme.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(319, 136);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(319, 205);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 17;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(16, 209);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(121, 209);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 19;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(223, 209);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 20;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // FormDeneme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(dataGridView1);
            Controls.Add(dateDeneme);
            Controls.Add(label7);
            Controls.Add(txtNet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtYanlış);
            Controls.Add(txtDogru);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDers);
            Controls.Add(txtOgrenci);
            Controls.Add(label2);
            Controls.Add(txtDeneme);
            Controls.Add(label1);
            Name = "FormDeneme";
            Text = "FormDeneme";
            Load += FormDeneme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDeneme;
        private Label label2;
        private TextBox txtOgrenci;
        private TextBox txtDers;
        private Label label3;
        private Label label4;
        private TextBox txtDogru;
        private TextBox txtYanlış;
        private Label label5;
        private Label label6;
        private TextBox txtNet;
        private Label label7;
        private DateTimePicker dateDeneme;
        private DataGridView dataGridView1;
        private Button btnListele;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}