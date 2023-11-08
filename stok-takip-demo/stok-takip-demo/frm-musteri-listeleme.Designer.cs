namespace stok_takip_demo
{
    partial class frm_musteri_listeleme
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
            Button btnGuncelle;
            label6 = new Label();
            txtTcAra = new TextBox();
            btnSil = new Button();
            txtMail = new TextBox();
            txtAdres = new TextBox();
            txtTel = new TextBox();
            txtAd = new TextBox();
            txtTc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(221, 374);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 36;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(455, 90);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 39;
            label6.Text = "Tc Ara";
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(521, 87);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(161, 27);
            txtTcAra.TabIndex = 38;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(99, 374);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 37;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(143, 317);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(146, 27);
            txtMail.TabIndex = 35;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(143, 273);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(146, 27);
            txtAdres.TabIndex = 34;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(143, 227);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(146, 27);
            txtTel.TabIndex = 33;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(143, 185);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(146, 27);
            txtAd.TabIndex = 32;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(143, 143);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(146, 27);
            txtTc.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 320);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 30;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 273);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 29;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 230);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 28;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 188);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 27;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 146);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 26;
            label1.Text = "TC";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(342, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(675, 260);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // frm_musteri_listeleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1044, 491);
            Controls.Add(label6);
            Controls.Add(txtTcAra);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtMail);
            Controls.Add(txtAdres);
            Controls.Add(txtTel);
            Controls.Add(txtAd);
            Controls.Add(txtTc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frm_musteri_listeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_musteri_listeleme";
            Load += frm_musteri_listeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtTcAra;
        private Button btnSil;
        private TextBox txtMail;
        private TextBox txtAdres;
        private TextBox txtTel;
        private TextBox txtAd;
        private TextBox txtTc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}