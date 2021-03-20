using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.Models;
using KEKBeterPhoto.ImageControls.ImageStrategys;

namespace KEKBeterPhoto.ImageControls.ProccessingMetods
{
    class MedianFilterMetod : IProccessingStrategy
    {
        /// <summary>
        ///  Медианный метод обработки
        ///  https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D0%B4%D0%B8%D0%B0%D0%BD%D0%BD%D1%8B%D0%B9_%D1%84%D0%B8%D0%BB%D1%8C%D1%82%D1%80
        /// </summary>
        public List<Pixel> ProccessingWork(List<Pixel> pixels)
        {
            for(int i =0; i <= pixels.Count;i++) 
            {

            }

            return pixels;
        }
    }
}
