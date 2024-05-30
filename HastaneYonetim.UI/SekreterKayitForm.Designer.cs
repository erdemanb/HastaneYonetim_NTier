namespace HastaneYonetim.UI
{
    partial class SekreterKayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterKayitForm));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptBoxGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnKaydet.Location = new System.Drawing.Point(400, 414);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 47);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydı Tamamla";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAd.Location = new System.Drawing.Point(296, 148);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(80, 26);
            this.lblKullaniciAd.TabIndex = 2;
            this.lblKullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Location = new System.Drawing.Point(336, 191);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(40, 26);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.BackColor = System.Drawing.Color.Transparent;
            this.lblSifreTekrar.Location = new System.Drawing.Point(299, 234);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(77, 26);
            this.lblSifreTekrar.TabIndex = 4;
            this.lblSifreTekrar.Text = "Şifre Tekrar:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Location = new System.Drawing.Point(347, 277);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 26);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Location = new System.Drawing.Point(329, 320);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 26);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(382, 145);
            this.txtKullaniciAdi.MaxLength = 80;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(218, 30);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(382, 188);
            this.txtSifre.MaxLength = 80;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(218, 30);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(382, 231);
            this.txtSifreTekrar.MaxLength = 80;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(218, 30);
            this.txtSifreTekrar.TabIndex = 2;
            this.txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(382, 274);
            this.txtAd.MaxLength = 80;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(218, 30);
            this.txtAd.TabIndex = 3;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(382, 360);
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(217, 30);
            this.mskTelefon.TabIndex = 5;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefon.Location = new System.Drawing.Point(323, 363);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 26);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(382, 316);
            this.txtSoyad.MaxLength = 80;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(218, 30);
            this.txtSoyad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(23, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Geri";
            // 
            // ptBoxGeri
            // 
            this.ptBoxGeri.BackColor = System.Drawing.Color.Transparent;
            this.ptBoxGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptBoxGeri.Image = ((System.Drawing.Image)(resources.GetObject("ptBoxGeri.Image")));
            this.ptBoxGeri.Location = new System.Drawing.Point(-2, 434);
            this.ptBoxGeri.Name = "ptBoxGeri";
            this.ptBoxGeri.Size = new System.Drawing.Size(85, 77);
            this.ptBoxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBoxGeri.TabIndex = 15;
            this.ptBoxGeri.TabStop = false;
            this.ptBoxGeri.Click += new System.EventHandler(this.ptBoxGeri_Click);
            // 
            // SekreterKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptBoxGeri);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAd);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SekreterKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterKayitForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptBoxGeri;
    }
}