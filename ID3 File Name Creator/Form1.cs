using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TagLib;

namespace ID3Namerv1
{
    public partial class Form1 : Form
    {
     List<Tag> tagList = new List<Tag>();
       
        public Form1()
        {
       
            InitializeComponent();
        }      
        private void btnSec_Click(object sender, EventArgs e)
        { 

            OpenFileDialog ofd = new OpenFileDialog(); 
            ofd.Multiselect = true;
            ofd.Filter = "MP3 Files|*.mp3";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            { 
                foreach (string fn in ofd.FileNames)
                {
                    dosyalariYukle(fn);
                }
                invalidFileNameCheck();
            }
            
        }

        private void invalidFileNameCheck()
        {
            foreach (ListViewItem i in lvTag.Items)
                if (i.BackColor == System.Drawing.Color.Red)
                {
                    MessageBox.Show(@"Kırmızı ile belirtilen dosyaların adları geçersizdir. (\ / : * ? "+'"'+" < > |) içerir.)");
                    break;
                }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {          
            int index = 0;
            try
            {            
                bool degistirildi = false; 
                foreach (Tag t in tagList)
                    if (lvTag.Items[index++].Checked == true)
                    {
                        t.renameFileName();                   
                        degistirildi = true;
                        
                    }
                if (degistirildi == true)
                    MessageBox.Show("Listedeki dosyaların isimleri değiştirildi.");
                else MessageBox.Show("Seçili dosya yok.");
                lvTag.Items.Clear();
                tagList.Clear();
            }
            catch (IOException)
            {
                MessageBox.Show(tagList[index-1].NewName+" isimli dosya mevcut");
            }
            catch (NotSupportedException)
            {
                MessageBox.Show(@"Dosya adı /\><"+'"'+ " : * ? | içeremez."+'\n'+ tagList[index-1].NewName);
 
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }
          
        
        }

        private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lvTag.Items)
                item.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void lnkSelectNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lvTag.Items)
                item.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lvTag.Items.Clear();
            tagList.Clear();
        }

        private void lvTag_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStripListRow.Show(Cursor.Position);
            }
        }

        private void kaldirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvTag.Items)
            {
                if (item.Selected==true)
                {
                    tagList.RemoveAt(item.Index);
                    item.Remove();
                }
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string foldername=fbd.SelectedPath;
                foreach (string fn in Directory.GetFiles(foldername))
                {
                    dosyalariYukle(fn);
                }
                invalidFileNameCheck();
            }
        }

        private void dosyalariYukle(string fn)
        {
            if (Path.GetExtension(fn) == ".mp3")
            {
                Tag tag = new Tag();
                TagLib.File f = TagLib.File.Create(fn);
                tag.setTag(f.Tag.FirstPerformer, f.Tag.Title, fn);
                tagList.Add(tag);


                ListViewItem item = new ListViewItem(tag.FInfo.Name);
                item.SubItems.Add(tag.NewName);
                item.SubItems.Add(tag.Artist);
                item.SubItems.Add(tag.Title);
                item.Checked = true;
                foreach (char c in Path.GetInvalidFileNameChars())
                    if (tag.NewName.Contains(c) == true)
                    {
                        
                        item.BackColor = System.Drawing.Color.Red;              
                    }
                lvTag.Items.Add(item);
            }
        }
        private void yeniDosyaAdınıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvTag.Items)
            {
                if (item.Selected == true)
                {
                   
                    FormYeniDosyaAdiDuzenle f = new FormYeniDosyaAdiDuzenle(tagList[item.Index]);
                    f.ShowDialog();
                    item.SubItems[1].Text = tagList[item.Index].NewName;
                    item.BackColor = System.Drawing.Color.White;              
                    foreach (char c in Path.GetInvalidFileNameChars())
                        if (tagList[item.Index].NewName.Contains(c) == true)
                        {
                            
                            item.BackColor = System.Drawing.Color.Red;              
                        }
                    item.SubItems[2].Text = tagList[item.Index].Artist;
                    item.SubItems[3].Text = tagList[item.Index].Title;
                   
                }
            }
            invalidFileNameCheck();
        }

        private void dosyaAdınıSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvTag.Items)
                if (item.Selected == true)
                {
                    tagList[item.Index].initializeName();
                    item.SubItems[1].Text = tagList[item.Index].NewName;
                }
        }      
    }
}
