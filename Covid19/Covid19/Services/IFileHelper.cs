using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Services
{
    public interface IFileHelper

    {
        string GetLocalFilePath(string filename);

        void SetIosKeyboard(bool enable);
    }
}
