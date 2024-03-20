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
        ViewModelBase CurrentViewModel { get; }
        void NavigateTo<T>() where T : ViewModelBase;
    }
    public class NavigationService : ObservableObject, InavigationService
    {
        private Func<Type, ViewModelBase> navFactory;
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public NavigationService(Func<Type, ViewModelBase> factory)
        {
            navFactory = factory;
        }

        public void NavigateTo<ViewModelType>() where ViewModelType : ViewModelBase
        {
            ViewModelBase _viewModel = navFactory.Invoke(typeof(ViewModelType));
            CurrentViewModel = _viewModel;
        }
    }
}
