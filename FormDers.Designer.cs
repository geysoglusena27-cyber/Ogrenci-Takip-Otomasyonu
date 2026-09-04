namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormDers
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
            label4 = new Label();
            txtKonu = new TextBox();
            dateDers = new DateTimePicker();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            txtDersID = new TextBox();
            txtOgrID = new TextBox();
            txtOgrtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 47);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 85);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğretmen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 114);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Ders Konusu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 149);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Ders Tarihi:";
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(85, 111);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(100, 23);
            txtKonu.TabIndex = 6;
            // 
            // dateDers
            // 
            dateDers.Location = new Point(96, 143);
            dateDers.Name = "dateDers";
            dateDers.Size = new Size(200, 23);
            dateDers.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 189);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(127, 189);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(265, 189);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(384, 189);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 14;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(599, 150);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 16;
            label5.Text = "DersID";
            // 
            // txtDersID
            // 
            txtDersID.Location = new Point(60, 14);
            txtDersID.Name = "txtDersID";
            txtDersID.ReadOnly = true;
            txtDersID.Size = new Size(100, 23);
            txtDersID.TabIndex = 17;
            // 
            // txtOgrID
            // 
            txtOgrID.Location = new Point(65, 48);
            txtOgrID.Name = "txtOgrID";
            txtOgrID.Size = new Size(100, 23);
            txtOgrID.TabIndex = 18;
            // 
            // txtOgrtID
            // 
            txtOgrtID.Location = new Point(80, 83);
            txtOgrtID.Name = "txtOgrtID";
            txtOgrtID.Size = new Size(100, 23);
            txtOgrtID.TabIndex = 19;
            // 
            // FormDers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 392);
            Controls.Add(txtOgrtID);
            Controls.Add(txtOgrID);
            Controls.Add(txtDersID);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dateDers);
            Controls.Add(txtKonu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDers";
            Text = "FormDers";
            Load += FormDers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtKonu;
        private DateTimePicker dateDers;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtDersID;
        private TextBox txtOgrID;
        private TextBox txtOgrtID;
    }
}