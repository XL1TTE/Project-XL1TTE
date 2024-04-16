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


        private ObservableCollection<DietModel> _dietList;
        public ObservableCollection<DietModel> DietList
        {
            get => _dietList;
            set
            {
                _dietList = value;

            }
        }


        public DietListViewModel(InavigationService navigation, DietBaseModel dietBaseModel)
        {
            Navigation = navigation;

            DietList = new ObservableCollection<DietModel>(dietBaseModel.DietList);

        }
    }
}
