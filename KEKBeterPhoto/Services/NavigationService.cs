﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace KEKBeterPhoto.Services
{
    class NavigationService
    {

        public event Action<Page> OnPageChanged;

        public void Navigate(Page page)
        {
            OnPageChanged?.Invoke(page);
        }
    }
}