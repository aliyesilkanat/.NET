namespace Producer_Version_Tracker
{
    partial class Form1
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
            this.btnDizinSec = new System.Windows.Forms.Button();
            this.grpDizinSec = new System.Windows.Forms.GroupBox();
            this.grpDizin = new System.Windows.Forms.GroupBox();
            this.btnCevirVeSil = new System.Windows.Forms.Button();
            this.txtSecilenDizin = new System.Windows.Forms.TextBox();
            this.grpDizindekiParcalar = new System.Windows.Forms.GroupBox();
            this.lvTracks = new System.Windows.Forms.ListView();
            this.clmnDosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpDizinSec.SuspendLayout();
            this.grpDizin.SuspendLayout();
            this.grpDizindekiParcalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDizinSec
            // 
            this.btnDizinSec.Location = new System.Drawing.Point(6, 19);
            this.btnDizinSec.Name = "btnDizinSec";
            this.btnDizinSec.Size = new System.Drawing.Size(257, 23);
            this.btnDizinSec.TabIndex = 0;
            this.btnDizinSec.Text = "Dizin Seç";
            this.btnDizinSec.UseVisualStyleBackColor = true;
            this.btnDizinSec.Click += new System.EventHandler(this.btnDizinSec_Click);
            // 
            // grpDizinSec
            // 
            this.grpDizinSec.Controls.Add(this.grpDizin);
            this.grpDizinSec.Location = new System.Drawing.Point(18, 12);
            this.grpDizinSec.Name = "grpDizinSec";
            this.grpDizinSec.Size = new System.Drawing.Size(521, 97);
            this.grpDizinSec.TabIndex = 2;
            this.grpDizinSec.TabStop = false;
            // 
            // grpDizin
            // 
            this.grpDizin.Controls.Add(this.btnCevirVeSil);
            this.grpDizin.Controls.Add(this.btnDizinSec);
            this.grpDizin.Controls.Add(this.txtSecilenDizin);
            this.grpDizin.Location = new System.Drawing.Point(6, 10);
            this.grpDizin.Name = "grpDizin";
            this.grpDizin.Size = new System.Drawing.Size(503, 81);
            this.grpDizin.TabIndex = 0;
            this.grpDizin.TabStop = false;
            // 
            // btnCevirVeSil
            // 
            this.btnCevirVeSil.Location = new System.Drawing.Point(269, 19);
            this.btnCevirVeSil.Name = "btnCevirVeSil";
            this.btnCevirVeSil.Size = new System.Drawing.Size(228, 23);
            this.btnCevirVeSil.TabIndex = 1;
            this.btnCevirVeSil.Text = "Çevir Ve Sil";
            this.btnCevirVeSil.UseVisualStyleBackColor = true;
            this.btnCevirVeSil.Click += new System.EventHandler(this.btnCevirVeSil_Click);
            // 
            // txtSecilenDizin
            // 
            this.txtSecilenDizin.Location = new System.Drawing.Point(7, 48);
            this.txtSecilenDizin.Name = "txtSecilenDizin";
            this.txtSecilenDizin.ReadOnly = true;
            this.txtSecilenDizin.Size = new System.Drawing.Size(256, 20);
            this.txtSecilenDizin.TabIndex = 1;
            // 
            // grpDizindekiParcalar
            // 
            this.grpDizindekiParcalar.Controls.Add(this.lvTracks);
            this.grpDizindekiParcalar.Location = new System.Drawing.Point(18, 115);
            this.grpDizindekiParcalar.Name = "grpDizindekiParcalar";
            this.grpDizindekiParcalar.Size = new System.Drawing.Size(515, 221);
            this.grpDizindekiParcalar.TabIndex = 3;
            this.grpDizindekiParcalar.TabStop = false;
            this.grpDizindekiParcalar.Text = "Dizine Yeni Eklenen Parçalar";
            // 
            // lvTracks
            // 
            this.lvTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnDosyaAdi});
            this.lvTracks.Location = new System.Drawing.Point(12, 20);
            this.lvTracks.Name = "lvTracks";
            this.lvTracks.Size = new System.Drawing.Size(288, 195);
            this.lvTracks.TabIndex = 0;
            this.lvTracks.UseCompatibleStateImageBehavior = false;
            this.lvTracks.View = System.Windows.Forms.View.Details;
            // 
            // clmnDosyaAdi
            // 
            this.clmnDosyaAdi.Text = "Dosya Adı";
            this.clmnDosyaAdi.Width = 278;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 383);
            this.Controls.Add(this.grpDizindekiParcalar);
            this.Controls.Add(this.grpDizinSec);
            this.Name = "Form1";
            this.Text = "Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDizinSec.ResumeLayout(false);
            this.grpDizin.ResumeLayout(false);
            this.grpDizin.PerformLayout();
            this.grpDizindekiParcalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDizinSec;
        private System.Windows.Forms.GroupBox grpDizinSec;
        private System.Windows.Forms.TextBox txtSecilenDizin;
        private System.Windows.Forms.GroupBox grpDizindekiParcalar;
        private System.Windows.Forms.GroupBox grpDizin;
        private System.Windows.Forms.Button btnCevirVeSil;
        private System.Windows.Forms.ListView lvTracks;
        private System.Windows.Forms.ColumnHeader clmnDosyaAdi;
    }
}

