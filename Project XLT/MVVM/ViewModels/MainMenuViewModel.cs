﻿using Project_XLT.MVVM.Core;
using Project_XLT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.ViewModels
{
    public class MainMenuViewModel: ViewModelBase
    {
        private InavigationService? _navigation;
        public InavigationService? Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }


        private string? _test;
        public string? Test
        {
            get => _test;
            set
            {
                _test = value;

            }
        }


        public MainMenuViewModel(InavigationService navigationservice)
        {
            Navigation = navigationservice;
            Test = "Работает";
        }
    }


}
