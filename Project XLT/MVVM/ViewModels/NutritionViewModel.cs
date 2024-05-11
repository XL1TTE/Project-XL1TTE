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
using System.Windows.Input;
using System.Windows;
using Microsoft.Xaml.Behaviors.Core;

namespace Project_XLT.MVVM.ViewModels
{
    public class NutritionViewModel : ViewModelBase
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


        private readonly PeoplesDataBase _PeoplesDataBase;

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


        private DateTime _currentDateTime = DateTime.Now;
        public DateTime CurrentDateTime
        {
            get => _currentDateTime;
            set
            {
                _currentDateTime = value;
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


        private bool _isSearchPopup;
        public bool IsSearchPopup
        {
            get => _isSearchPopup;
            set
            {
                _isSearchPopup = value;
                OnPropertyChanged();

            }
        }

        
        private ObservableCollection<Product> _eatenFoodList = new ObservableCollection<Product>();
        public ObservableCollection<Product> EatenFoodList
        {
            get => _eatenFoodList;
            set
            {
                _eatenFoodList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Product> _foodList;
        public ObservableCollection<Product> FoodList
        {
            get => _foodList;
            set
            {
                _foodList = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<Person> _peoplesDataBase;
        public ObservableCollection<Person> PeoplesDataBase
        {
            get => _peoplesDataBase;
            set
            {
                _peoplesDataBase = value;
                OnPropertyChanged();
            }
        }


        private string _searchPeopleFieldText;
        public string SearchPeopleFieldText
        {
            get => _searchPeopleFieldText;
            set
            {
                _searchPeopleFieldText = value;
                PeopleListToViewUpdate();
                OnPropertyChanged();
            }
        }

        private string _searchFoodFieldText;
        public string SearchFoodFieldText
        {
            get => _searchFoodFieldText;
            set
            {
                _searchFoodFieldText = value;               
                OnPropertyChanged();
                FoodListToViewUpdate();
            }
        }

        private Visibility _isFoodListVisible;
        public Visibility IsFoodListVisible
        {
            get => _isFoodListVisible;
            set
            {
                _isFoodListVisible = value;
                OnPropertyChanged();

            }
        }

        private double? _coloriesInbasket = 0;
        public double? ColoriesInbasket
        {
            get => _coloriesInbasket;
            set
            {
                _coloriesInbasket = value;
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



        public RelayCommand OpenSearchPopup { get; set; }
        public RelayCommand OpenFoodListPopup { get; set; }
        public RelayCommand AddFoodCommand { get; set; }
        public RelayCommand RemoveFoodCommand { get; set; }
        public RelayCommand EatAllFood { get;set; }
        public RelayCommand ShowDietsListCommand { get; set; }

        public NutritionViewModel(InavigationService navigation, PeoplesDataBase peoples, DietBaseModel dietBaseModel)
        {
            Navigation = navigation;

            _PeoplesDataBase = peoples;
            _PeoplesDataBase.GeneratePeoples(10);

            PeoplesDataBase = peoples.PeoplesData;
            FoodList = LocalFoodDataBase.Products;

            DietBaseModel = dietBaseModel;

            OpenSearchPopup = new RelayCommand(o => { IsSearchPopup = (IsSearchPopup ? false : true); }, o => true);

            OpenFoodListPopup = new RelayCommand(o => { IsFoodListVisible = (IsFoodListVisible == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible); 
            }, o => true);


            //Food Commands
            AddFoodCommand = new RelayCommand(o =>
            {
                RoutedEventArgs args = o as RoutedEventArgs;
                var clickedItem = args.OriginalSource as Button;
                if (clickedItem != null)
                {
                    Product product = clickedItem.DataContext as Product;
                    EatenFoodList.Add(product);
                    ColoriesInbasket += product.Colories;
                }
            }, o => true);
            RemoveFoodCommand = new RelayCommand(o =>
            {
                RoutedEventArgs args = o as RoutedEventArgs;
                var clickedItem = args.OriginalSource as Button;
                if (clickedItem != null)
                {
                    Product product = clickedItem.DataContext as Product;
                    EatenFoodList.Remove(product);
                    ColoriesInbasket -= product.Colories;
                }

            }, o=> true);
            EatAllFood = new RelayCommand(o => EatAllFoodInBasket(), o=>true);

            ShowDietsListCommand = new RelayCommand(o => { Navigation.GlobalNavigateTo<DietListViewModel>(); },  o=>true );

            Minerals = 50;
            Water = 75;
            Proteins = 100;
            Carbs = 33;
            Vitamins = 10;
            Fats = 87;

        }


        private void EatAllFoodInBasket()
        {
            foreach(Product product in EatenFoodList)
            {
                ColoriesInbasket += product.ColoriesSum;
                Carbs += Convert.ToInt32(product.Carbs);
                Water += Convert.ToInt32(product.Water);
                Proteins += Convert.ToInt32(product.Proteins);
                Carbs += Convert.ToInt32(product.Carbs);
                Fats += Convert.ToInt32(product.Fats);
            }
            EatenFoodList.Clear();


        }
        private void PeopleListToViewUpdate()
        {
            ObservableCollection<Person> Data = _PeoplesDataBase.PeoplesData;
            ObservableCollection<Person> DataTemp = new ObservableCollection<Person>();
            foreach (Person person in Data)
            {
                if (person.Name.Contains(SearchPeopleFieldText))
                {
                    DataTemp.Add(person);
                }
            }
            PeoplesDataBase = DataTemp;
        }

        private void FoodListToViewUpdate()
        {
            ObservableCollection<Product> Data = LocalFoodDataBase.Products;
            ObservableCollection<Product> DataTemp = new ObservableCollection<Product>();
            foreach (Product product in Data)
            {
                if (product.Title.Contains(SearchFoodFieldText))
                {
                    DataTemp.Add(product);
                }
            }
            FoodList = DataTemp;
        }

    }
}
