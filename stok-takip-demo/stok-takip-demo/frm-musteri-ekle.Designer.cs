namespace stok_takip_demo
{
    partial class frm_musteri_ekle
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
            label5 = new Label();
            txtTc = new TextBox();
            txtAd = new TextBox();
            txtTel = new TextBox();
            txtAdres = new TextBox();
            txtMail = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 65);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 107);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 149);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 192);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 239);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "E-mail";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(147, 62);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(147, 104);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(147, 146);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 7;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(147, 189);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 8;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(147, 236);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(217, 312);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm_musteri_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(351, 373);
            Controls.Add(button1);
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
            Name = "frm_musteri_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekle";
            Load += frm_musteri_ekle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTc;
        private TextBox txtAd;
        private TextBox txtTel;
        private TextBox txtAdres;
        private TextBox txtMail;
        private Button button1;
    }
}