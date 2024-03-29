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


        public RelayCommand NavigateToNutrition { get; set; }
        public RelayCommand NavigateToMainMenu { get; set; }
        public RelayCommand ExitCommand { get; set; }
        public MainWindowViewModel(InavigationService navigation)
        {
            Navigation = navigation;
            Navigation.NavigateTo<MainMenuViewModel>();
            NavigateToNutrition = new RelayCommand(o => { Navigation.NavigateTo<NutritionViewModel>(); }, o => true);
            NavigateToMainMenu = new RelayCommand(o => { Navigation.NavigateTo <MainMenuViewModel>(); }, o => true);
            ExitCommand = new RelayCommand(o => { Application.Current.Shutdown(); }, o=> true);
        }
    }
}
