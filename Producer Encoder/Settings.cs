using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Producer_Version_Tracker
{
    class Settings
    {
        private string userDirectory;

        public string UserDirectory
        {
            get { return userDirectory; }
            set { userDirectory = value; }
        }
        private string configPath;

        public string ConfigPath
        {
            get { return configPath; }
            set { configPath = value; }
        }
        private string configFile;

        public string ConfigFile
        {
            get { return configFile; }
            set { configFile = value; }
        }
       public bool setConfigPath()
       {
           configPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
           configPath = Path.Combine(configPath, "Producer Version Tracker");
           configFile = configPath + @"\config.ini";
   
           return configFileCheck();
       }
     
       private bool configFileCheck()
       {
           if (!Directory.Exists(configPath))
           {
               Directory.CreateDirectory(configPath);
               return false;
           }
           else if (!File.Exists(ConfigFile))
               return false;
           else
           {
               StreamReader sr = new StreamReader(this.ConfigFile);
               this.UserDirectory = sr.ReadLine();
               sr.Dispose();
               return true;
           }
       }
    }
}
