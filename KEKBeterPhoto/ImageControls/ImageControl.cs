using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.Models;
using System.Windows.Media.Imaging;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace KEKBeterPhoto.ImageControl
{
    class ImageControl
    {
        #region Veriabels
        public enum ProccessingMetod //vnj
        {
            NoPrccening,
            MedianFilter,
            HSV,
            СorrectionValueControllers,
            BilateralFilter,
            SpectralRepresentationOfASignal,
            DominantDirection,
            LocalClassificationOfFragments,
            EffectiveCompression
        };

        public enum SizeImageMetod
        {
            NoResizing,
            X2Resizing
        };

        public enum SaveImageMetod
        {
            SaveUsPNG,
            SaveUsJPEG,
            SaveUsBMP,
            SaveUsTGA

        };

        #endregion

        #region Constructors

        public ProccessingMetod _ProccessingMEtod { get; set; }

        public SizeImageMetod _SizeImageMetod { get; set; }

        public SaveImageMetod _SaveImageMetod { get; set; }

        #endregion

        #region Models

        // public ObservableCollection<Pixel> pixels { get; set; } = new ObservableCollection<Pixel>();


        #endregion

        public ImageControl(ImageModel imageModel, ProccessingMetod processingMetod, SizeImageMetod sizeImageMetod,SaveImageMetod saveImageMetod  )
        {
            BitmapSource RawDelultBitmapSource = ImageJpegOpen(imageModel);



            
         
        }

        #region ProssedImageMetods

        private void MedianFilterMetod() //MedianFilter 
        {

        }

        private void HSVMetod() //HSV 
        {

        }

        private void СorrectionValueControllersMetod() //СorrectionValueControllers 
        {

        }

        private void BilateralFilterMetod() //BilateralFilter 
        {

        }

        private void SpectralRepresentationOfASignalMetod() //SpectralRepresentationOfASignal 
        {

        }

        private void DominantDirectionMetod() //DominantDirection 
        {
        
        }

        private void LocalClassificationOfFragmentsMetod() //LocalClassificationOfFragments 
        {

        }

        private void EffectiveCompressionMetod() //EffectiveCompression 
        {

        }

        #endregion

        #region SizeImageMetods

        public void X2ResizingMetod() 
        {

        }

        #endregion

        #region SaveProssedMetods

        private void SaveClipboardImageToPNGFile(string filePath) //Save us PNG format
        {
            var image = Clipboard.GetImage();
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(fileStream);
            }
        }

        private void SaveClipboardImageToJPEGFile(string fileName, int quality, BitmapSource bmp)
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

        #endregion

        #region ProcessingBitmapMetod

        private BitmapSource ImageJpegOpen(ImageModel imageModel) // Open a Stream and decode a JPEG image
        {
            Stream imageStreamSource = new FileStream(imageModel.ImageSource, FileMode.Open, FileAccess.Read, FileShare.Read);
            JpegBitmapDecoder decoder = new JpegBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                
            return decoder.Frames[0];
        }

        //private List<Pixel> GetPixels(BitmapSource RawImageBitmapSource) 
        //{
        //    var pixels = new List<Pixel>(RawImageBitmapSource.PixelWidth * RawImageBitmapSource.PixelHeight);

        //    for (int i=0; i<= RawImageBitmapSource.PixelHeight; i++) 
        //    {
        //        for (int k = 0; k <= RawImageBitmapSource.PixelWidth; i++) 
        //        {
        //            pixels.Add(new Pixel()
        //            {
        //                Color = RawImageBitmapSource.CopyPixels
        //            });
        //        }
        //    }

        //} 

        private byte[] BitmapSourceToArray(BitmapSource RawImageBitmapSource) //BitmapSource to byte[]
        {
            // Stride = (width) x (bytes per pixel)
            int stride = (int)RawImageBitmapSource.PixelWidth * (RawImageBitmapSource.Format.BitsPerPixel / 8);
            byte[] pixels = new byte[(int)RawImageBitmapSource.PixelHeight * stride];

            RawImageBitmapSource.CopyPixels(pixels, stride, 0);

            return pixels;
        }

        private BitmapSource BitmapSourceFromArray(byte[] pixels, int width, int height) //byte[] to BitmapSource
        {
            WriteableBitmap bitmap = new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgra32, null);

            bitmap.WritePixels(new Int32Rect(0, 0, width, height), pixels, width * (bitmap.Format.BitsPerPixel / 8), 0);

            return bitmap;
        }

         

        #endregion



    }
}
