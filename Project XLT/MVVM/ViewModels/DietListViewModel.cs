using Project_XLT.MVVM.Core;
using Project_XLT.MVVM.Model;
using Project_XLT.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Project_XLT.MVVM.ViewModels
{
    public class DietListViewModel: ViewModelBase
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

        private DietBaseModel _dietBaseModel;
        public DietBaseModel DietBaseModel
        {
            get => _dietBaseModel;
            set
            {
                _dietBaseModel = value;
                OnPropertyChanged();
            }
        }
        


        private ObservableCollection<DietModel> _dietList;
        public ObservableCollection<DietModel> DietList
        {
            get => _dietList;
            set
            {
                _dietList = value;
                OnPropertyChanged();
            }
        }


        private DietModel _pickedDiet;
        public DietModel PickedDiet
        {
            get => _pickedDiet;
            set
            {
                _pickedDiet = value;
                OnPropertyChanged();

            }
        }


        public RelayCommand PickDietCommand { get; set; }
        public RelayCommand NavigateToNutritionCommand { get; set; }
        public DietListViewModel(InavigationService navigation, DietBaseModel dietBaseModel)
        {
            Navigation = navigation;

            DietList = new ObservableCollection<DietModel>(dietBaseModel.DietList);
            DietBaseModel = dietBaseModel;

            PickDietCommand = new RelayCommand(o => { PickDietFunc(o); }, o=>true);
            NavigateToNutritionCommand = new RelayCommand(o => { Navigation.GlobalNavigateTo<GeneralViewModel>(); }, o => true);

        }

        private void PickDietFunc(object o)
        {
            RoutedEventArgs args = o as RoutedEventArgs;
            var clickedItem = args.OriginalSource as RadioButton;
            if (clickedItem != null)
            {

                DietModel diet = clickedItem.DataContext as DietModel;

                PickedDiet = diet;
                DietBaseModel.ChoosenDiet = PickedDiet;

                foreach (DietModel dietModel in DietList)
                {
                    if (dietModel.Equals(diet) == false)
                    {
                        dietModel.IsDietChoosed = false;
                    }
                }

            }
        }
    }
}
