namespace Öğrenci_Takip_Otomasyonu
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnOgrenci = new Button();
            btnDers = new Button();
            btnDevamsızlık = new Button();
            btnOdeme = new Button();
            btnRapor = new Button();
            btnSonuc = new Button();
            btnDurum = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Takip Sistemi";
            // 
            // btnOgrenci
            // 
            btnOgrenci.BackColor = SystemColors.MenuHighlight;
            btnOgrenci.Location = new Point(248, 36);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(228, 41);
            btnOgrenci.TabIndex = 1;
            btnOgrenci.Text = "Öğrenci İşlemleri";
            btnOgrenci.UseVisualStyleBackColor = false;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // btnDers
            // 
            btnDers.BackColor = SystemColors.MenuHighlight;
            btnDers.Location = new Point(248, 83);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(228, 41);
            btnDers.TabIndex = 2;
            btnDers.Text = "Ders İşlemleri";
            btnDers.UseVisualStyleBackColor = false;
            btnDers.Click += btnDers_Click;
            // 
            // btnDevamsızlık
            // 
            btnDevamsızlık.BackColor = SystemColors.MenuHighlight;
            btnDevamsızlık.Location = new Point(248, 130);
            btnDevamsızlık.Name = "btnDevamsızlık";
            btnDevamsızlık.Size = new Size(228, 41);
            btnDevamsızlık.TabIndex = 3;
            btnDevamsızlık.Text = "Devamsızlık";
            btnDevamsızlık.UseVisualStyleBackColor = false;
            btnDevamsızlık.Click += btnDevamsızlık_Click;
            // 
            // btnOdeme
            // 
            btnOdeme.BackColor = SystemColors.MenuHighlight;
            btnOdeme.Location = new Point(248, 266);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(228, 41);
            btnOdeme.TabIndex = 4;
            btnOdeme.Text = "Ödeme Takibi";
            btnOdeme.UseVisualStyleBackColor = false;
            btnOdeme.Click += btnOdeme_Click;
            // 
            // btnRapor
            // 
            btnRapor.BackColor = SystemColors.MenuHighlight;
            btnRapor.Location = new Point(248, 313);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(228, 41);
            btnRapor.TabIndex = 5;
            btnRapor.Text = "Raporlar";
            btnRapor.UseVisualStyleBackColor = false;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnSonuc
            // 
            btnSonuc.BackColor = SystemColors.MenuHighlight;
            btnSonuc.Location = new Point(248, 177);
            btnSonuc.Name = "btnSonuc";
            btnSonuc.Size = new Size(228, 41);
            btnSonuc.TabIndex = 6;
            btnSonuc.Text = "Deneme Sonuç";
            btnSonuc.UseVisualStyleBackColor = false;
            btnSonuc.Click += btnSonuc_Click_1;
            // 
            // btnDurum
            // 
            btnDurum.BackColor = SystemColors.MenuHighlight;
            btnDurum.Location = new Point(248, 219);
            btnDurum.Name = "btnDurum";
            btnDurum.Size = new Size(228, 41);
            btnDurum.TabIndex = 7;
            btnDurum.Text = "Akademik Durum";
            btnDurum.UseVisualStyleBackColor = false;
            btnDurum.Click += btnDurum_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 366);
            Controls.Add(btnDurum);
            Controls.Add(btnSonuc);
            Controls.Add(btnRapor);
            Controls.Add(btnOdeme);
            Controls.Add(btnDevamsızlık);
            Controls.Add(btnDers);
            Controls.Add(btnOgrenci);
            Controls.Add(label1);
            Name = "FormMenu";
            Text = "Öğrenci Takip Otomasyonu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOgrenci;
        private Button btnDers;
        private Button btnOdeme;
        private Button btnDevamsızlık;
        private Button btnRapor;
        private Button button1;
        private Button btnSonuc;
        private Button btnDurum;
    }
}
