using Covid19.Services.iOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(FiileHelperiOS))]
namespace Covid19.Services.iOS
{
    public class FiileHelperiOS : IFileHelper
    {
        public FiileHelperiOS()
        {
        }
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }

        public void SetIosKeyboard(bool enable)
        {
            Xamarin.IQKeyboardManager.SharedManager.Enable = enable;

        }
    }
}
