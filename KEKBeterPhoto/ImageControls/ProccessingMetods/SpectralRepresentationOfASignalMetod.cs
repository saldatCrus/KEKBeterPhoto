using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.Models;
using KEKBeterPhoto.ImageControls.ImageStrategys;

namespace KEKBeterPhoto.ImageControls.ProccessingMetods
{
    class SpectralRepresentationOfASignalMetod : IProccessingStrategy
    {
        /// <summary>
        ///  Метод обработки
        /// </summary>
        public List<Pixel> ProccessingWork(List<Pixel> pixels)
        {
            return pixels;
        }
    }
}
