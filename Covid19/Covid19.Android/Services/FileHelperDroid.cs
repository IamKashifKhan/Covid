using System;
using System.IO;
using Xamarin.Forms;
using Covid19.Services.Droid;
 

[assembly: Dependency(typeof(FileHelperDroid))]

namespace Covid19.Services.Droid
{
    public class FileHelperDroid : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
        public void SetIosKeyboard(bool enable)
        { }
    }
}
