namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormRapor
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
            dataGridView1 = new DataGridView();
            btnOgrenciListesi = new Button();
            btnOdemeRaporu = new Button();
            lblToplam = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 153);
            dataGridView1.TabIndex = 0;
            // 
            // btnOgrenciListesi
            // 
            btnOgrenciListesi.Location = new Point(7, 14);
            btnOgrenciListesi.Name = "btnOgrenciListesi";
            btnOgrenciListesi.Size = new Size(183, 28);
            btnOgrenciListesi.TabIndex = 1;
            btnOgrenciListesi.Text = "Öğrenci Listesi";
            btnOgrenciListesi.UseVisualStyleBackColor = true;
            btnOgrenciListesi.Click += btnOgrenciListesi_Click;
            // 
            // btnOdemeRaporu
            // 
            btnOdemeRaporu.Location = new Point(9, 48);
            btnOdemeRaporu.Name = "btnOdemeRaporu";
            btnOdemeRaporu.Size = new Size(181, 28);
            btnOdemeRaporu.TabIndex = 2;
            btnOdemeRaporu.Text = "Ödeme Raporu";
            btnOdemeRaporu.UseVisualStyleBackColor = true;
            btnOdemeRaporu.Click += btnOdemeRaporu_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(459, 299);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(70, 15);
            lblToplam.TabIndex = 19;
            lblToplam.Text = "Toplam:0 TL";
            // 
            // FormRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 323);
            Controls.Add(lblToplam);
            Controls.Add(btnOdemeRaporu);
            Controls.Add(btnOgrenciListesi);
            Controls.Add(dataGridView1);
            Name = "FormRapor";
            Text = "FormRapor";
            Load += FormRapor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOgrenciListesi;
        private Button btnOdemeRaporu;
        private Label lblToplam;
    }
}