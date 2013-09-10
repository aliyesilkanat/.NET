namespace ID3Namerv1
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lvTag = new System.Windows.Forms.ListView();
            this.clmnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnNewFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpSec = new System.Windows.Forms.GroupBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpID3 = new System.Windows.Forms.GroupBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.Wrapper = new System.Windows.Forms.GroupBox();
            this.grpTasi = new System.Windows.Forms.GroupBox();
            this.splitTasiDegistir = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDegistirVeTasi = new System.Windows.Forms.Button();
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.txtMuzikKlasoru = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkSelectNone = new System.Windows.Forms.LinkLabel();
            this.lnkSelectAll = new System.Windows.Forms.LinkLabel();
            this.menuStripListRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSec.SuspendLayout();
            this.grpID3.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.grpTasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTasiDegistir)).BeginInit();
            this.splitTasiDegistir.Panel1.SuspendLayout();
            this.splitTasiDegistir.Panel2.SuspendLayout();
            this.splitTasiDegistir.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStripListRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(5, 19);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(119, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Dosya Seç";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // lvTag
            // 
            this.lvTag.AllowDrop = true;
            this.lvTag.CheckBoxes = true;
            this.lvTag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnFileName,
            this.clmnNewFileName,
            this.clmnArtist,
            this.clmnTitle});
            this.lvTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTag.FullRowSelect = true;
            this.lvTag.GridLines = true;
            this.lvTag.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTag.LabelWrap = false;
            this.lvTag.Location = new System.Drawing.Point(3, 16);
            this.lvTag.Name = "lvTag";
            this.lvTag.Size = new System.Drawing.Size(862, 240);
            this.lvTag.TabIndex = 2;
            this.lvTag.UseCompatibleStateImageBehavior = false;
            this.lvTag.View = System.Windows.Forms.View.Details;
            this.lvTag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTag_MouseClick);
            // 
            // clmnFileName
            // 
            this.clmnFileName.Text = "Dosya Adı";
            this.clmnFileName.Width = 210;
            // 
            // clmnNewFileName
            // 
            this.clmnNewFileName.Text = "Yeni Dosya Adı";
            this.clmnNewFileName.Width = 180;
            // 
            // clmnArtist
            // 
            this.clmnArtist.Text = "Artist";
            this.clmnArtist.Width = 249;
            // 
            // clmnTitle
            // 
            this.clmnTitle.Text = "Ttitle";
            this.clmnTitle.Width = 218;
            // 
            // grpSec
            // 
            this.grpSec.Controls.Add(this.btnFolder);
            this.grpSec.Controls.Add(this.btnReset);
            this.grpSec.Controls.Add(this.btnChoose);
            this.grpSec.Location = new System.Drawing.Point(12, 12);
            this.grpSec.Name = "grpSec";
            this.grpSec.Size = new System.Drawing.Size(877, 50);
            this.grpSec.TabIndex = 1;
            this.grpSec.TabStop = false;
            this.grpSec.Text = "Adları Değişecek Parçaların Bulunduğu Dosyayı/Klasörü Seç";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(130, 19);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(143, 23);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "Klasör Seç";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(467, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(404, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpID3
            // 
            this.grpID3.Controls.Add(this.lvTag);
            this.grpID3.Location = new System.Drawing.Point(3, 26);
            this.grpID3.Name = "grpID3";
            this.grpID3.Size = new System.Drawing.Size(868, 259);
            this.grpID3.TabIndex = 4;
            this.grpID3.TabStop = false;
            this.grpID3.Text = "ID3";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDegistir.Location = new System.Drawing.Point(3, 45);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(414, 23);
            this.btnDegistir.TabIndex = 5;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.grpTasi);
            this.Wrapper.Controls.Add(this.panel1);
            this.Wrapper.Controls.Add(this.grpSec);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(895, 468);
            this.Wrapper.TabIndex = 6;
            this.Wrapper.TabStop = false;
            // 
            // grpTasi
            // 
            this.grpTasi.Controls.Add(this.splitTasiDegistir);
            this.grpTasi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTasi.Location = new System.Drawing.Point(3, 365);
            this.grpTasi.Name = "grpTasi";
            this.grpTasi.Size = new System.Drawing.Size(889, 100);
            this.grpTasi.TabIndex = 7;
            this.grpTasi.TabStop = false;
            this.grpTasi.Text = "Değiştir";
            // 
            // splitTasiDegistir
            // 
            this.splitTasiDegistir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTasiDegistir.Location = new System.Drawing.Point(3, 16);
            this.splitTasiDegistir.Name = "splitTasiDegistir";
            // 
            // splitTasiDegistir.Panel1
            // 
            this.splitTasiDegistir.Panel1.Controls.Add(this.groupBox2);
            this.splitTasiDegistir.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitTasiDegistir.Panel2
            // 
            this.splitTasiDegistir.Panel2.Controls.Add(this.groupBox1);
            this.splitTasiDegistir.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitTasiDegistir.Size = new System.Drawing.Size(883, 81);
            this.splitTasiDegistir.SplitterDistance = 449;
            this.splitTasiDegistir.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDegistirVeTasi);
            this.groupBox2.Controls.Add(this.btnKlasorSec);
            this.groupBox2.Controls.Add(this.txtMuzikKlasoru);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adı Değiştir ve Seçilen Klasöre Taşı";
            // 
            // btnDegistirVeTasi
            // 
            this.btnDegistirVeTasi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDegistirVeTasi.Location = new System.Drawing.Point(3, 45);
            this.btnDegistirVeTasi.Name = "btnDegistirVeTasi";
            this.btnDegistirVeTasi.Size = new System.Drawing.Size(433, 23);
            this.btnDegistirVeTasi.TabIndex = 2;
            this.btnDegistirVeTasi.Text = "Değiştir ve Klasöre Taşı";
            this.btnDegistirVeTasi.UseVisualStyleBackColor = true;
            this.btnDegistirVeTasi.Click += new System.EventHandler(this.btnDegistirVeTasi_Click);
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(3, 19);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(125, 23);
            this.btnKlasorSec.TabIndex = 0;
            this.btnKlasorSec.Text = "Taşınacak Klasörü Seç";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // txtMuzikKlasoru
            // 
            this.txtMuzikKlasoru.Location = new System.Drawing.Point(137, 21);
            this.txtMuzikKlasoru.Name = "txtMuzikKlasoru";
            this.txtMuzikKlasoru.Size = new System.Drawing.Size(299, 20);
            this.txtMuzikKlasoru.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adı Değiştir";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpID3);
            this.panel1.Controls.Add(this.lnkSelectNone);
            this.panel1.Controls.Add(this.lnkSelectAll);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 288);
            this.panel1.TabIndex = 6;
            // 
            // lnkSelectNone
            // 
            this.lnkSelectNone.AutoSize = true;
            this.lnkSelectNone.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkSelectNone.Location = new System.Drawing.Point(73, 5);
            this.lnkSelectNone.Name = "lnkSelectNone";
            this.lnkSelectNone.Size = new System.Drawing.Size(80, 13);
            this.lnkSelectNone.TabIndex = 3;
            this.lnkSelectNone.TabStop = true;
            this.lnkSelectNone.Text = "Hiçbirini Seçme";
            this.lnkSelectNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectNone_LinkClicked);
            // 
            // lnkSelectAll
            // 
            this.lnkSelectAll.AutoSize = true;
            this.lnkSelectAll.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkSelectAll.Location = new System.Drawing.Point(3, 5);
            this.lnkSelectAll.Name = "lnkSelectAll";
            this.lnkSelectAll.Size = new System.Drawing.Size(64, 13);
            this.lnkSelectAll.TabIndex = 3;
            this.lnkSelectAll.TabStop = true;
            this.lnkSelectAll.Text = "Hepsini Seç";
            this.lnkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
            // 
            // menuStripListRow
            // 
            this.menuStripListRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.duzenleToolStripMenuItem});
            this.menuStripListRow.Name = "menuStripListRow";
            this.menuStripListRow.Size = new System.Drawing.Size(117, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Kaldır";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.kaldirToolStripMenuItem_Click);
            // 
            // duzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "duzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.duzenleToolStripMenuItem.Text = "Düzenle";
            this.duzenleToolStripMenuItem.Click += new System.EventHandler(this.yeniDosyaAdınıDüzenleToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 468);
            this.Controls.Add(this.Wrapper);
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Text = "ID3 Tag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSec.ResumeLayout(false);
            this.grpID3.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            this.grpTasi.ResumeLayout(false);
            this.splitTasiDegistir.Panel1.ResumeLayout(false);
            this.splitTasiDegistir.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTasiDegistir)).EndInit();
            this.splitTasiDegistir.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStripListRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListView lvTag;
        private System.Windows.Forms.GroupBox grpSec;
        private System.Windows.Forms.ColumnHeader clmnArtist;
        private System.Windows.Forms.ColumnHeader clmnTitle;
        private System.Windows.Forms.GroupBox grpID3;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.GroupBox Wrapper;
        private System.Windows.Forms.ColumnHeader clmnFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkSelectNone;
        private System.Windows.Forms.LinkLabel lnkSelectAll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ContextMenuStrip menuStripListRow;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.ColumnHeader clmnNewFileName;
        private System.Windows.Forms.ToolStripMenuItem duzenleToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTasi;
        private System.Windows.Forms.TextBox txtMuzikKlasoru;
        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.Button btnDegistirVeTasi;
        private System.Windows.Forms.SplitContainer splitTasiDegistir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

