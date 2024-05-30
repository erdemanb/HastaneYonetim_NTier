namespace HastaneYonetim.UI
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.btnSekreterKayit = new System.Windows.Forms.Button();
            this.btnSekreterGiris = new System.Windows.Forms.Button();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.ptBoxKapat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSekreterKayit
            // 
            this.btnSekreterKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnSekreterKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreterKayit.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterKayit.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSekreterKayit.Location = new System.Drawing.Point(161, 298);
            this.btnSekreterKayit.Name = "btnSekreterKayit";
            this.btnSekreterKayit.Size = new System.Drawing.Size(143, 50);
            this.btnSekreterKayit.TabIndex = 0;
            this.btnSekreterKayit.Text = "Sekreter Kayıt";
            this.btnSekreterKayit.UseVisualStyleBackColor = false;
            this.btnSekreterKayit.Click += new System.EventHandler(this.btnSekreterKayit_Click);
            // 
            // btnSekreterGiris
            // 
            this.btnSekreterGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnSekreterGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreterGiris.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterGiris.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSekreterGiris.Location = new System.Drawing.Point(360, 298);
            this.btnSekreterGiris.Name = "btnSekreterGiris";
            this.btnSekreterGiris.Size = new System.Drawing.Size(143, 50);
            this.btnSekreterGiris.TabIndex = 1;
            this.btnSekreterGiris.Text = "Sekreter Giriş";
            this.btnSekreterGiris.UseVisualStyleBackColor = false;
            this.btnSekreterGiris.Click += new System.EventHandler(this.btnSekreterGiris_Click);
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktorGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorGiris.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGiris.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDoktorGiris.Location = new System.Drawing.Point(558, 298);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(143, 50);
            this.btnDoktorGiris.TabIndex = 2;
            this.btnDoktorGiris.Text = "Doktor Giriş";
            this.btnDoktorGiris.UseVisualStyleBackColor = false;
            // 
            // ptBoxKapat
            // 
            this.ptBoxKapat.BackColor = System.Drawing.Color.Transparent;
            this.ptBoxKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptBoxKapat.Image = ((System.Drawing.Image)(resources.GetObject("ptBoxKapat.Image")));
            this.ptBoxKapat.Location = new System.Drawing.Point(-1, 431);
            this.ptBoxKapat.Name = "ptBoxKapat";
            this.ptBoxKapat.Size = new System.Drawing.Size(85, 77);
            this.ptBoxKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBoxKapat.TabIndex = 3;
            this.ptBoxKapat.TabStop = false;
            this.ptBoxKapat.Click += new System.EventHandler(this.ptBoxKapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(19, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kapat";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptBoxKapat);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.btnSekreterGiris);
            this.Controls.Add(this.btnSekreterKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisForm";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSekreterKayit;
        private System.Windows.Forms.Button btnSekreterGiris;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.PictureBox ptBoxKapat;
        private System.Windows.Forms.Label label1;
    }
}