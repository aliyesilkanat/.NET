using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
namespace Producer_Version_Tracker
{
    class Track
    {
        public Track(string f)
        {
            FilePath = f;
            FileName = Path.GetFileNameWithoutExtension(f);
        } 
        private string nonFormattedFileName(string name)
        {
            string extension = System.IO.Path.GetExtension(name);
            string formatsizDosyaAdi = name.Substring(0, name.Length - extension.Length);

            return formatsizDosyaAdi;
        }
       
        public void ConvertWavMP3(Settings settings, bool waitFlag)
        {
            string fileName = this.FilePath;
            string pworkingDir = settings.UserDirectory;
            //maxLen is in ms (1000 = 1 second) 
            string outfile = settings.UserDirectory;
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.FileName =Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+ @"\lame.exe" ;
                //"\""+pworkingDir + @"\lame.exe" + "\"";
            //psi.Arguments = "-v2" + ' ' + fileName + "\" \"" + Path.GetFullPath(fileName) + ".mp3" + "\"";
            
            psi.Arguments = "-V2 -b320 --verbose " + '"' + fileName + "\" \"" + nonFormattedFileName(Path.GetFullPath(fileName)) + ".mp3" + "\"";
            //psi.WorkingDirectory=pworkingDir; 
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            if (waitFlag)
            {
                
                p.WaitForExit();
                // wait for exit of called application 
            }
        
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

       
    }
}
