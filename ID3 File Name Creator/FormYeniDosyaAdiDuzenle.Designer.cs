namespace ID3Namerv1
{
    partial class FormYeniDosyaAdiDuzenle
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
            this.lblYeniDosyaAdi = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.grpID3 = new System.Windows.Forms.GroupBox();
            this.txtYeniAd = new System.Windows.Forms.TextBox();
            this.grpAdiDegistir = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnID3Guncelle = new System.Windows.Forms.Button();
            this.grpID3.SuspendLayout();
            this.grpAdiDegistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYeniDosyaAdi
            // 
            this.lblYeniDosyaAdi.AutoSize = true;
            this.lblYeniDosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblYeniDosyaAdi.Location = new System.Drawing.Point(6, 16);
            this.lblYeniDosyaAdi.Name = "lblYeniDosyaAdi";
            this.lblYeniDosyaAdi.Size = new System.Drawing.Size(104, 17);
            this.lblYeniDosyaAdi.TabIndex = 0;
            this.lblYeniDosyaAdi.Text = "Yeni Dosya Adı";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblArtist.Location = new System.Drawing.Point(11, 17);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 15);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitle.Location = new System.Drawing.Point(11, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(71, 20);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(229, 20);
            this.txtArtist.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(71, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // grpID3
            // 
            this.grpID3.Controls.Add(this.btnID3Guncelle);
            this.grpID3.Controls.Add(this.txtTitle);
            this.grpID3.Controls.Add(this.lblArtist);
            this.grpID3.Controls.Add(this.txtArtist);
            this.grpID3.Controls.Add(this.lblTitle);
            this.grpID3.Location = new System.Drawing.Point(15, 5);
            this.grpID3.Name = "grpID3";
            this.grpID3.Size = new System.Drawing.Size(306, 98);
            this.grpID3.TabIndex = 3;
            this.grpID3.TabStop = false;
            // 
            // txtYeniAd
            // 
            this.txtYeniAd.Location = new System.Drawing.Point(9, 36);
            this.txtYeniAd.Name = "txtYeniAd";
            this.txtYeniAd.Size = new System.Drawing.Size(291, 20);
            this.txtYeniAd.TabIndex = 4;
            this.txtYeniAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniAd_KeyPress);
            // 
            // grpAdiDegistir
            // 
            this.grpAdiDegistir.Controls.Add(this.btnKaydet);
            this.grpAdiDegistir.Controls.Add(this.lblYeniDosyaAdi);
            this.grpAdiDegistir.Controls.Add(this.txtYeniAd);
            this.grpAdiDegistir.Location = new System.Drawing.Point(15, 103);
            this.grpAdiDegistir.Name = "grpAdiDegistir";
            this.grpAdiDegistir.Size = new System.Drawing.Size(306, 100);
            this.grpAdiDegistir.TabIndex = 5;
            this.grpAdiDegistir.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(9, 63);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(291, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnID3Guncelle
            // 
            this.btnID3Guncelle.Location = new System.Drawing.Point(71, 67);
            this.btnID3Guncelle.Name = "btnID3Guncelle";
            this.btnID3Guncelle.Size = new System.Drawing.Size(229, 23);
            this.btnID3Guncelle.TabIndex = 6;
            this.btnID3Guncelle.Text = "Güncelle";
            this.btnID3Guncelle.UseVisualStyleBackColor = true;
            this.btnID3Guncelle.Click += new System.EventHandler(this.btnID3Guncelle_Click);
            // 
            // FormYeniDosyaAdiDuzenle
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.grpAdiDegistir);
            this.Controls.Add(this.grpID3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormYeniDosyaAdiDuzenle";
            this.Text = "Yeni Dosya Adı";
            this.Load += new System.EventHandler(this.FormYeniDosyaAdiDuzenle_Load);
            this.grpID3.ResumeLayout(false);
            this.grpID3.PerformLayout();
            this.grpAdiDegistir.ResumeLayout(false);
            this.grpAdiDegistir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYeniDosyaAdi;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox grpID3;
        private System.Windows.Forms.TextBox txtYeniAd;
        private System.Windows.Forms.GroupBox grpAdiDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnID3Guncelle;
    }
}