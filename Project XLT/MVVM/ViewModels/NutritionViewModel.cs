using Project_XLT.MVVM.Core;
using Project_XLT.MVVM.Model;
using Project_XLT.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        private string _searchFieldText;
        public string SearchFieldText
        {
            get => _searchFieldText;
            set
            {
                _searchFieldText = value;
                PeopleListToViewUpdate();
                OnPropertyChanged();
            }
        }



        public RelayCommand OpenSearchPopup { get; set; }

        public NutritionViewModel(InavigationService navigation, PeoplesDataBase peoples)
        {
            Navigation = navigation;
            
            _PeoplesDataBase = peoples;
            _PeoplesDataBase.GeneratePeoples(10);

            PeoplesDataBase = peoples.PeoplesData;


            OpenSearchPopup = new RelayCommand(o => IsSearchPopup = true, o=>true);

            Minerals = 50;
            Water = 75;
            Proteins = 100;
            Carbs = 33;
            Vitamins = 10;
            Fats = 87;

        }


        private void PeopleListToViewUpdate()
        {
            ObservableCollection<Person> Data = _PeoplesDataBase.PeoplesData;
            ObservableCollection<Person> DataTemp = new ObservableCollection<Person>();
            foreach (Person person in Data)
            {
                if (person.Name.Contains(SearchFieldText))
                {
                    DataTemp.Add(person);
                }
            }
            PeoplesDataBase = DataTemp;
        }
    }
}
