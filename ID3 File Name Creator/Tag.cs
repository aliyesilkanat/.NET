using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ID3Namerv1
{
    public class Tag
    {
        private string newName;

        public string NewName
        {
            get { return newName; }
            set { newName = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string codec;

        public string Codec
        {
            get { return codec; }
            set { codec = value; }
        }
      
        private FileInfo fInfo;

        public FileInfo FInfo
        {
            get { return fInfo; }
            set { fInfo = value; }
        }
        
        public Tag(string a, string t, string d)
        {
            Artist = a;
            Title = t;
            FInfo = new FileInfo(d);
            Codec = FInfo.Extension;
         
        }
        public Tag(Tag t)
        {
            FInfo = t.FInfo;
            Artist = t.Artist;
            Title = t.Title;
            Codec = t.Codec;
        }
        public Tag()
        {
            FInfo = null;
            Artist = null;
            Title = null;
            Codec = null;
        }
        public void setTag(string a, string t, string d)
        {
            Artist = a;
            Title = t;
            FInfo = new FileInfo(d);
            Codec = FInfo.Extension;
            initializeName();
        }
        private string defaultNewName()
        {
            return Artist + " - " + Title + Codec;
        }
        public void renameFileName()
        {
            Exception nonSelectedFileException = new Exception();
            if (FInfo != null)
            {
                File.Move(FInfo.FullName,Path.Combine(FInfo.DirectoryName,NewName));
            }
            else throw nonSelectedFileException;
        }
        public void initializeName()
        {
            NewName = defaultNewName();
        }
        public void renameID3(string artist,string title)
        {           
            this.Artist = artist;
            this.Title = title;
            //f.Tag.Artists[0] = Artist;
            this.initializeName();
            using (TagLib.File f = TagLib.File.Create(FInfo.FullName))
            {

                f.Tag.Performers = null;
                f.Tag.Performers = new []{artist};
                f.Tag.Title = title;
                f.Save();
            }

           
        }

    }
}
