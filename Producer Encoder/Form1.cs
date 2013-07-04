using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Producer_Version_Tracker
{
    public partial class Form1 : Form
    {
        List<Track> trackList = new List<Track>();
        Settings settings = new Settings();
        public Form1()
        {   
            InitializeComponent();            
        }
        private void btnDizinSec_Click(object sender, EventArgs e)
        {
            defaultDiziniSec();
        }
        private void btnYeniParcalariYukle_Click(object sender, EventArgs e)
        {
            loadTracks();
        }
        private void loadTracks()
        {                        
            foreach (string file in Directory.GetFiles(settings.UserDirectory, "*.wav"))
            {              
                Track tr = new Track(file);
                ListViewItem item = new ListViewItem(tr.FileName);
                lvTracks.Items.Add(item);
                trackList.Add(tr);
            }        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!settings.setConfigPath())
            {
                MessageBox.Show("Parçaların tutulduğu dosyayı seçiniz");
                defaultDiziniSec();
                this.Activate();
            }
            else txtSecilenDizin.Text = settings.UserDirectory;
            loadTracks();
        }
        private void defaultDiziniSec()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settings.UserDirectory = fbd.SelectedPath;
                StreamWriter sw = new StreamWriter(File.Create(settings.ConfigFile));
                sw.Write(settings.UserDirectory);
                sw.Dispose();
                trackList.Clear();
                txtSecilenDizin.Text = fbd.SelectedPath;
            }          
        }
        private void btnCevirVeSil_Click(object sender, EventArgs e)
        {      
            foreach (Track tr in trackList)
            {
                tr.ConvertWavMP3(settings, true);
                File.Delete(tr.FilePath);
            }     
            MessageBox.Show("Parçalar MP3 formatına çevrildi.");
            this.Close();
        }
        private string nonFormattedFileName(string name)
        {
            string extension = System.IO.Path.GetExtension(name);
            string formatsizDosyaAdi = name.Substring(0, name.Length - extension.Length);

            return formatsizDosyaAdi;
        }
       
    }
}
