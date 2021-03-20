using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using KEKBeterPhoto.ImageControls.ImageStrategys;

namespace KEKBeterPhoto.ImageControls.SaveImageMetods
{
    class SaveClipboardImageToPNGFile : ISaveImageStrategy
    {
        public void SaveImageWork(string filePath, int quality, BitmapSource bmp) 
        {
            var image = Clipboard.GetImage();
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(fileStream);
            }
        }
    }
}
