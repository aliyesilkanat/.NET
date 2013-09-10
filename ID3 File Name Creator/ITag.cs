using System;
namespace ID3Namerv1
{
    interface ITag
    {
        string Artist { get; set; }
        string Codec { get; set; }
        System.IO.FileInfo FInfo { get; set; }
        void initializeName();
        string NewName { get; set; }
        void setTag(string a, string t, string d);
        string Title { get; set; }
    }
}
