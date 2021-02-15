using System;
using System.Collections.Generic;   
using System.Text;
using KEKBeterPhoto.Models;
using System.Windows.Media.Imaging;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using KEKBeterPhoto.ImageControls.SaveImageMetods;
using KEKBeterPhoto.ImageControls.ProccessingMetods;
using KEKBeterPhoto.ImageControls.SizeImageMetods;
using KEKBeterPhoto.ImageControls;
using System.Drawing;

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

        public ProccessingMetod _ProccessingMetod { get; set; }

        public SizeImageMetod _SizeImageMetod { get; set; }

        public SaveImageMetod _SaveImageMetod { get; set; }

        #endregion

        #region Models

        private List<Pixel> pixels { get; set; } = new List<Pixel>();

        #endregion

        public ImageControl(ImageModel imageModel, ProccessingMetod processingMetod, SizeImageMetod sizeImageMetod, SaveImageMetod saveImageMetod)
        {
            #region class

            var RawImageBitmap = new Bitmap(imageModel.ImageSource);

            var ImageProccesing = new ImageProccessing();

            #endregion


            pixels = GetPixels(RawImageBitmap);

            #region Switch-enum processing set
            switch (processingMetod)
            {
                case ProccessingMetod.NoPrccening:
                    break;
                case ProccessingMetod.MedianFilter: pixels = ImageProccesing.DoProccessing(new MedianFilterMetod(), pixels);
                    break;
                case ProccessingMetod.HSV: pixels = ImageProccesing.DoProccessing(new HSVMetod(), pixels);
                    break;
                case ProccessingMetod.СorrectionValueControllers: pixels = ImageProccesing.DoProccessing(new СorrectionValueControllersMetod(), pixels);
                    break;
                case ProccessingMetod.BilateralFilter: pixels = ImageProccesing.DoProccessing(new BilateralFilterMetod(), pixels);
                    break;
                case ProccessingMetod.SpectralRepresentationOfASignal: pixels = ImageProccesing.DoProccessing(new SpectralRepresentationOfASignalMetod(), pixels);
                    break;
                case ProccessingMetod.DominantDirection: pixels = ImageProccesing.DoProccessing(new DominantDirectionMetod(), pixels);
                    break;
                case ProccessingMetod.LocalClassificationOfFragments: pixels = ImageProccesing.DoProccessing(new LocalClassificationOfFragmentsMetod(), pixels);
                    break;
                case ProccessingMetod.EffectiveCompression: pixels = ImageProccesing.DoProccessing(new EffectiveCompressionMetod(), pixels);
                    break;
            }
            #endregion

            #region Switch-enum save set
            switch (saveImageMetod)
            {
                case SaveImageMetod.SaveUsPNG:  
                    break;
                case SaveImageMetod.SaveUsJPEG:  
                    break;
                case SaveImageMetod.SaveUsBMP:  
                    break;
                case SaveImageMetod.SaveUsTGA:  
                    break;
            }

        }
        #endregion

        #region ProcessingBitmapMetod

        //private BitmapSource ImageJpegOpen(ImageModel imageModel) // Open a Stream and decode a JPEG image
        //{
        //    Stream imageStreamSource = new FileStream(imageModel.ImageSource, FileMode.Open, FileAccess.Read, FileShare.Read);
        //    JpegBitmapDecoder decoder = new JpegBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);

        //    return decoder.Frames[0];
        //}

        private List<Pixel> GetPixels(Bitmap RawImageBitmap) 
        {
            var pixels = new List<Pixel>(RawImageBitmap.Width * RawImageBitmap.Height);

            for (int y = 0; y <= RawImageBitmap.Height; y++)
            {
                for (int x = 0; x <= RawImageBitmap.Width; x++)
                {
                    pixels.Add(new Pixel()
                    {
                        Color = RawImageBitmap.GetPixel(x,y),

                        Point = new System.Drawing.Point(){Y = y, X = x }

                    });
                }
            }
            return pixels;

        } // Konvert bitmap to list of Pixel



        //private byte[] BitmapSourceToArray(BitmapSource RawImageBitmapSource) //BitmapSource to byte[]
        //{
        //    // Stride = (width) x (bytes per pixel)
        //    int stride = (int)RawImageBitmapSource.PixelWidth * (RawImageBitmapSource.Format.BitsPerPixel / 8);
        //    byte[] pixels = new byte[(int)RawImageBitmapSource.PixelHeight * stride];

        //    RawImageBitmapSource.CopyPixels(pixels, stride, 0);

        //    return pixels;
        //}

        //private BitmapSource BitmapSourceFromArray(byte[] pixels, int width, int height) //byte[] to BitmapSource
        //{
        //    WriteableBitmap bitmap = new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgra32, null);

        //    bitmap.WritePixels(new Int32Rect(0, 0, width, height), pixels, width * (bitmap.Format.BitsPerPixel / 8), 0);

        //    return bitmap;
        //}



        #endregion



    }
}
