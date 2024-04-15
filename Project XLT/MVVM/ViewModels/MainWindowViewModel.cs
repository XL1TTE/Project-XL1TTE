using Project_XLT.MVVM.Core;
using Project_XLT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_XLT.MVVM.ViewModels
{
    public class MainWindowViewModel: ViewModelBase
    {
        private InavigationService _navigation;
        public InavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel(InavigationService navigation)
        {
            Navigation = navigation;
            Navigation.GlobalNavigateTo<GeneralViewModel>();
        }
    }
}
