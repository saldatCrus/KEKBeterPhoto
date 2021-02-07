using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace KEKBeterPhoto.ImageControls.SaveImageMetods
{
    class SaveClipboardImageToJPEGFile : ISaveImageStrategy
    {
        public void SaveImageWork(string fileName, int quality, BitmapSource bmp)
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            BitmapFrame outputFrame = BitmapFrame.Create(bmp);
            encoder.Frames.Add(outputFrame);
            encoder.QualityLevel = quality;

            using (FileStream file = File.OpenWrite(fileName))
            {
                encoder.Save(file);
            }
        }
    }
}
