namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormDevamsızlık
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
            dateTarih = new DateTimePicker();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            dataGridView1 = new DataGridView();
            txtOgrenciID = new TextBox();
            txtDersID = new TextBox();
            label5 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Ders:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "Tarih:";
            // 
            // dateTarih
            // 
            dateTarih.Location = new Point(86, 100);
            dateTarih.Name = "dateTarih";
            dateTarih.Size = new Size(200, 23);
            dateTarih.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(21, 167);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(116, 167);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(211, 167);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(319, 167);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 16;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(403, 150);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtOgrenciID
            // 
            txtOgrenciID.Location = new Point(76, 33);
            txtOgrenciID.Name = "txtOgrenciID";
            txtOgrenciID.Size = new Size(100, 23);
            txtOgrenciID.TabIndex = 18;
            // 
            // txtDersID
            // 
            txtDersID.Location = new Point(76, 61);
            txtDersID.Name = "txtDersID";
            txtDersID.Size = new Size(94, 23);
            txtDersID.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 5);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 20;
            label5.Text = "DevamsızlıkID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(86, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 21;
            // 
            // FormDevamsızlık
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 354);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(txtDersID);
            Controls.Add(txtOgrenciID);
            Controls.Add(dataGridView1);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dateTarih);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDevamsızlık";
            Text = "FormDevamsızlık";
            Load += FormDevamsızlık_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTarih;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private DataGridView dataGridView1;
        private TextBox txtOgrenciID;
        private TextBox txtDersID;
        private Label label5;
        private TextBox txtID;
    }
}