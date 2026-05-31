namespace otopark2
{
    partial class FormAbone
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPlaka = new TextBox();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            cmbAboneTipi = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dtBaslangic = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtBitis = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dataGridViewAboneler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAboneler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Plaka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(21, 55);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(31, 96);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(10, 135);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 0;
            label4.Text = "Abone Tipi";
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(106, 12);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(152, 23);
            txtPlaka.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(106, 52);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(152, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(106, 93);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(152, 23);
            txtTelefon.TabIndex = 1;
            // 
            // cmbAboneTipi
            // 
            cmbAboneTipi.FormattingEnabled = true;
            cmbAboneTipi.Items.AddRange(new object[] { "Haftalık", "Aylık", "Yıllık" });
            cmbAboneTipi.Location = new Point(106, 132);
            cmbAboneTipi.Name = "cmbAboneTipi";
            cmbAboneTipi.Size = new Size(152, 23);
            cmbAboneTipi.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 3;
            label5.Text = "Başlangıç";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(5, 219);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 3;
            label6.Text = "Bitiş Tarihi";
            // 
            // dtBaslangic
            // 
            dtBaslangic.Checked = true;
            dtBaslangic.CustomizableEdges = customizableEdges1;
            dtBaslangic.FillColor = Color.White;
            dtBaslangic.Font = new Font("Segoe UI", 9F);
            dtBaslangic.Format = DateTimePickerFormat.Long;
            dtBaslangic.Location = new Point(106, 177);
            dtBaslangic.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtBaslangic.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtBaslangic.Name = "dtBaslangic";
            dtBaslangic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtBaslangic.Size = new Size(152, 22);
            dtBaslangic.TabIndex = 4;
            dtBaslangic.Value = new DateTime(2026, 5, 25, 21, 14, 31, 64);
            // 
            // dtBitis
            // 
            dtBitis.Checked = true;
            dtBitis.CustomizableEdges = customizableEdges3;
            dtBitis.FillColor = Color.White;
            dtBitis.Font = new Font("Segoe UI", 9F);
            dtBitis.Format = DateTimePickerFormat.Long;
            dtBitis.Location = new Point(106, 219);
            dtBitis.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtBitis.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtBitis.Name = "dtBitis";
            dtBitis.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtBitis.Size = new Size(152, 22);
            dtBitis.TabIndex = 4;
            dtBitis.Value = new DateTime(2026, 5, 25, 21, 14, 31, 64);
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SandyBrown;
            btnEkle.Location = new Point(865, 15);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(119, 34);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Abone Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.SandyBrown;
            btnGuncelle.Location = new Point(865, 55);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(119, 35);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += button2_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.SandyBrown;
            btnSil.Location = new Point(865, 96);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 37);
            btnSil.TabIndex = 5;
            btnSil.Text = "Abonelik İptal";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += button3_Click;
            // 
            // dataGridViewAboneler
            // 
            dataGridViewAboneler.BackgroundColor = Color.White;
            dataGridViewAboneler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAboneler.GridColor = Color.White;
            dataGridViewAboneler.Location = new Point(264, 10);
            dataGridViewAboneler.Name = "dataGridViewAboneler";
            dataGridViewAboneler.Size = new Size(595, 229);
            dataGridViewAboneler.TabIndex = 6;
            // 
            // FormAbone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(985, 429);
            Controls.Add(dataGridViewAboneler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dtBitis);
            Controls.Add(dtBaslangic);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbAboneTipi);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtPlaka);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAbone";
            Text = "FormAbone.cs";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAboneler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPlaka;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private ComboBox cmbAboneTipi;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBaslangic;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBitis;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dataGridViewAboneler;
    }
}