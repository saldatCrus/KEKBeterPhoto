using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using DevExpress.Mvvm;
using System.ComponentModel;
using System.Windows.Controls;
using KEKBeterPhoto.Services;
using System.Collections.ObjectModel;
using KEKBeterPhoto.Models;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Input;

namespace KEKBeterPhoto.ViewModels
{

    class MainViewModel : BindableBase
    {

        #region Variables

        #endregion

        #region Constructors

        public Page MemberTrackPage { get; set; }

        public bool ComboBoxIsEnabled { get; set; }

        public bool ComboBoxIsEnabled1 { get; set; }

        public bool ComboBoxIsEnabled2 { get; set; }

        public bool CheckBoxIsChecked { get; set; }

        public bool CheckBoxIsChecked1 { get; set; }

        public bool CheckBoxIsChecked2 { get; set; }

        public int ProgressBarValue { get; set; }

        #endregion

        #region Models

        public ObservableCollection<ImageModel> ImageModels { get; set; } = new ObservableCollection<ImageModel>();

        #endregion

        public MainViewModel()
        {
            ProgressBarValue = 50;




        }

        #region Icommands

        public ICommand OpenFileDialog => new DelegateCommand(() =>
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.Jpg, *.Png) | *.jpg; *.png;";
            ofd.Multiselect = true;
            var result = ofd.ShowDialog();
            if (result == true)
            {
                foreach (string FileName in ofd.FileNames)
                {
                    foreach (string SafeFileName in ofd.SafeFileNames)
                    {
                        if (FileName.Contains(SafeFileName))
                        {
                            Trace.WriteLine("Была добавлена композиция" + SafeFileName);
                            ImageModels.Add(new ImageModel
                            {
                                ImageTitle = SafeFileName,
                                ImageSource = FileName,
                                
                            });

                        }


                    }

                }
            }


        }); // Open File Dialog Metod

        public ICommand StartOperetionButton => new DelegateCommand(() =>
        {


        });


        #endregion

        }
}

