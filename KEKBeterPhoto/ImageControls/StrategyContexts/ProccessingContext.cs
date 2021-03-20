using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.Models;
using System.Threading.Tasks;
using System.Linq;
using KEKBeterPhoto.ImageControls.ImageStrategys;

namespace KEKBeterPhoto.ImageControls.StrategyContexts
{
    class ProccessingContext
    {
        public List<Pixel> DoProccessing(IProccessingStrategy proccessingStrategy, List<Pixel> pixels) 
        {
            if(proccessingStrategy != null) 
            {
                return proccessingStrategy.ProccessingWork(pixels);
            }
            return null;
        }
    }
}
