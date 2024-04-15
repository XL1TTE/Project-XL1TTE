using System;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Project_XLT.MVVM.View;
using Project_XLT.MVVM.ViewModels;
using Project_XLT.Services;
using Project_XLT.MVVM.Core;
using Project_XLT.MVVM.Model;

namespace Project_XLT
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceCollection services;
        private readonly IServiceProvider serviceProvider;
        public App()
        {
            services = new ServiceCollection();

            services.AddSingleton<MainWindow>(provider => new MainWindow { DataContext = provider.GetRequiredService<MainWindowViewModel>() });
            

            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<NutritionViewModel>();
            services.AddSingleton<MainMenuViewModel>();
            services.AddSingleton<GeneralViewModel>();


            services.AddSingleton<InavigationService, NavigationService>();

            services.AddSingleton<Func<Type, ViewModelBase>>(provider => viewModelType => (ViewModelBase)provider.GetRequiredService(viewModelType));


            // Custom Services
            services.AddSingleton<PeoplesDataBase>();

            serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var MainWindow = serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
