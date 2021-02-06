using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace KEKBeterPhoto.Models
{
    class ImageModel : BindableBase
    {
        public string ImageTitle { get; set; }

        public string ImageSource { get; set; }

    }
}
