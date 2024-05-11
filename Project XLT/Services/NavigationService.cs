using Project_XLT.MVVM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.Services
{
    public interface InavigationService
    {
        ViewModelBase? GlobalCurrentViewModel { get; }
        ViewModelBase? GenerallocalcurrentViewModel { get; }
        void GlobalNavigateTo<T>() where T : ViewModelBase;
        void GeneralNavigateTo<T>() where T : ViewModelBase;
    }
    public class NavigationService : ObservableObject, InavigationService
    {
        private Func<Type, ViewModelBase> navFactory;
        private ViewModelBase? _globalcurrentViewModel;
        public ViewModelBase? GlobalCurrentViewModel
        {
            get => _globalcurrentViewModel;
            set
            {
                _globalcurrentViewModel = value;
                OnPropertyChanged();
            }
        }
        private ViewModelBase? _generallocalcurrentViewModel;
        public ViewModelBase? GenerallocalcurrentViewModel
        {
            get => _generallocalcurrentViewModel;
            set
            {
                _generallocalcurrentViewModel = value;
                OnPropertyChanged();
            }
        }

        public NavigationService(Func<Type, ViewModelBase> factory)
        {
            navFactory = factory;
        }

        public void GlobalNavigateTo<ViewModelType>() where ViewModelType : ViewModelBase
        {
            ViewModelBase _viewModel = navFactory.Invoke(typeof(ViewModelType));
            GlobalCurrentViewModel = _viewModel;
        }
        public void GeneralNavigateTo<ViewModelType>() where ViewModelType : ViewModelBase
        {
            ViewModelBase _viewModel = navFactory.Invoke(typeof(ViewModelType));
            GenerallocalcurrentViewModel = _viewModel;
        }
    }

}
