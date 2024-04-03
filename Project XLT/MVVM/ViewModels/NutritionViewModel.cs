using Project_XLT.MVVM.Core;
using Project_XLT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.ViewModels
{
    public class NutritionViewModel: ViewModelBase
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


        private int _carbs;
        public int Carbs
        {
            get => _carbs;
            set
            {
                _carbs = value;
                OnPropertyChanged();
            }
        }
        private int _fats;
        public int Fats
        {
            get => _fats;
            set
            {
                _fats = value;
                OnPropertyChanged();
            }
        }
        private int _proteins;
        public int Proteins
        {
            get => _proteins;
            set
            {
                _proteins = value;
                OnPropertyChanged();
            }
        }
        private int _vitamins;
        public int Vitamins
        {
            get => _vitamins;
            set
            {
                _vitamins = value;
                OnPropertyChanged();
            }
        }
        private int _minerals;
        public int Minerals
        {
            get => _minerals;
            set
            {
                _minerals = value;
                OnPropertyChanged();
            }
        }
        private int _water;
        public int Water
        {
            get => _water;
            set
            {
                _water = value;
                OnPropertyChanged();
            }
        }



        public NutritionViewModel(InavigationService navigation)
        {
            Navigation = navigation;

            Minerals = 50;
            Water = 75;
            Proteins = 100;
            Carbs = 33;
            Vitamins = 10;
            Fats = 87;

        }
    }
}
