using System;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Project_XLT.MVVM.View;
using Project_XLT.MVVM.ViewModels;
using Project_XLT.Services;
using Project_XLT.MVVM.Core;
using Project_XLT.MVVM.Model;
using Microsoft.Extensions.Hosting;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Newtonsoft.Json;
using System.IO;
using Project_XLT.FireBase;
using System.Threading.Tasks;
using System.Data;

namespace Project_XLT
{

    public partial class App : Application
    {
        private readonly IServiceCollection _services;
        private readonly IServiceProvider _serviceProvider;
        public App()
        {
            _services = new ServiceCollection();

            _services.AddSingleton<MainWindow>(provider => new MainWindow { DataContext = provider.GetRequiredService<MainWindowViewModel>() });

            _services.AddSingleton<MainWindowViewModel>();
            _services.AddSingleton<NutritionViewModel>();
            _services.AddSingleton<MainMenuViewModel>();
            _services.AddSingleton<GeneralViewModel>();
            _services.AddSingleton<DietListViewModel>();

            _services.AddSingleton<InavigationService, NavigationService>();

            _services.AddSingleton<Func<Type, ViewModelBase>>(provider => viewModelType => (ViewModelBase)provider.GetRequiredService(viewModelType));

            // Custom Services
            _services.AddSingleton<PeoplesDataBase>();
            _services.AddSingleton<DietBaseModel>();
            // FireBaseAuthConfiguration
            _services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAQA4nl2Jkw7Ah7SIJevhGRj1z6GDx21cw",
                AuthDomain = "op6-test.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider(),
                }
            }));
            _services.AddSingleton<IAuthService, FireBaseAuthService>();

            _serviceProvider = _services.BuildServiceProvider();
        }

        protected override  void OnStartup(StartupEventArgs e)
        {
            var MainWindow = _serviceProvider.GetRequiredService<MainWindow>();

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
