using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.Models;

namespace KEKBeterPhoto.ImageControls.ProccessingMetods
{
    class MedianFilterMetod : IProccessingStrategy
    {
        public List<Pixel> ProccessingWork(List<Pixel> pixels)
        {
            return pixels;
        }
    }
}
