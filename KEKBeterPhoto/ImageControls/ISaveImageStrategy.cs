using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace KEKBeterPhoto.ImageControls
{
    interface ISaveImageStrategy
    {
        void SaveImageWork(string filePath, int quality, BitmapSource bmp);
    }
}
