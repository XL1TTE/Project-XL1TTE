using Project_XLT.MVVM.Core;
using Project_XLT.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_XLT.MVVM.ViewModels
{
    public class GeneralViewModel: ViewModelBase
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
        public RelayCommand NavigateToDietMenu { get; set; }
        public GeneralViewModel(InavigationService navigation)
        {
            Navigation = navigation;
            Navigation.GeneralNavigateTo<MainMenuViewModel>();

            NavigateToNutrition = new RelayCommand(o => { Navigation.GeneralNavigateTo<NutritionViewModel>();}, o => true);
            NavigateToMainMenu = new RelayCommand(o => { Navigation.GeneralNavigateTo<MainMenuViewModel>();}, o => true);
            NavigateToDietMenu = new RelayCommand(o => { Navigation.GeneralNavigateTo<DietListViewModel>();}, o => true);
            ExitCommand = new RelayCommand(o => { Application.Current.Shutdown(); }, o => true);
        }

    }
}

