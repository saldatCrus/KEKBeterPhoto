using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.Models;

namespace KEKBeterPhoto.ImageControls
{
    interface IProccessingStrategy
    {
        List<Pixel> ProccessingWork(List<Pixel> pixels);
    }
}
