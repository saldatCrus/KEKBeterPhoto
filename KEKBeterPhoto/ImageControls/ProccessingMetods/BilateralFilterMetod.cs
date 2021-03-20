using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.Models;
using KEKBeterPhoto.ImageControls.ImageStrategys;

namespace KEKBeterPhoto.ImageControls.ProccessingMetods
{
    class BilateralFilterMetod : IProccessingStrategy
    {
        /// <summary>
        /// Билатериальный метод обработки
        /// https://en.wikipedia.org/wiki/Bilateral_filter
        /// </summary>   
        public List<Pixel> ProccessingWork(List<Pixel> pixels)
        {
            return pixels;
        }
    }
}
