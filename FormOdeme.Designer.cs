namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormOdeme
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
            txtTutar = new TextBox();
            dateOdeme = new DateTimePicker();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            dataGridView1 = new DataGridView();
            txtOgrID = new TextBox();
            label4 = new Label();
            txtOdemeID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Tutar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Ödeme Tarihi:";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(81, 66);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(100, 23);
            txtTutar.TabIndex = 6;
            // 
            // dateOdeme
            // 
            dateOdeme.Location = new Point(104, 105);
            dateOdeme.Name = "dateOdeme";
            dateOdeme.Size = new Size(200, 23);
            dateOdeme.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 149);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(126, 149);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(238, 149);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(330, 149);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 15;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(376, 150);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtOgrID
            // 
            txtOgrID.Location = new Point(81, 37);
            txtOgrID.Name = "txtOgrID";
            txtOgrID.Size = new Size(100, 23);
            txtOgrID.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 9);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 18;
            label4.Text = "OdemeID:";
            // 
            // txtOdemeID
            // 
            txtOdemeID.Location = new Point(77, 10);
            txtOdemeID.Name = "txtOdemeID";
            txtOdemeID.Size = new Size(100, 23);
            txtOdemeID.TabIndex = 19;
            // 
            // FormOdeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 356);
            Controls.Add(txtOdemeID);
            Controls.Add(label4);
            Controls.Add(txtOgrID);
            Controls.Add(dataGridView1);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dateOdeme);
            Controls.Add(txtTutar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormOdeme";
            Text = "FormOdeme";
            Load += FormOdeme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTutar;
        private DateTimePicker dateOdeme;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private DataGridView dataGridView1;
        private TextBox txtOgrID;
        private Label label4;
        private TextBox txtOdemeID;
    }
}