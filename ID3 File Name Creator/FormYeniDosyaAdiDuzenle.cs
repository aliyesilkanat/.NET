using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ID3Namerv1
{
    public partial class FormYeniDosyaAdiDuzenle : Form
    {
        Tag formdakiTag;
        string formatsizDosyaAdi; 
        public FormYeniDosyaAdiDuzenle(Tag t)
        {
            formdakiTag = t;
            InitializeComponent();
            txtArtist.Text = formdakiTag.Artist;
            txtTitle.Text = formdakiTag.Title;
            txtYeniAd.Text = nonFormattedFileName();
             txtYeniAd.Select();
        }

        private string nonFormattedFileName()
        {
            string extension = System.IO.Path.GetExtension(formdakiTag.NewName);
            formatsizDosyaAdi = formdakiTag.NewName.Substring(0, formdakiTag.NewName.Length - extension.Length);

            return formatsizDosyaAdi;
        }

        private void txtYeniAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar))
            foreach (char c in Path.GetInvalidFileNameChars())
                if (e.KeyChar == c)
                    e.Handled = true;
        }

        private void FormYeniDosyaAdiDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            formdakiTag.NewName = txtYeniAd.Text + formdakiTag.Codec;
                this.Close();
        }

        private void btnID3Guncelle_Click(object sender, EventArgs e)
        {
            formdakiTag.renameID3(txtArtist.Text, txtTitle.Text);


            txtYeniAd.Text = nonFormattedFileName();
        }
    }
}
