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

namespace Project_XLT
{

    public partial class App : Application
    {
        private readonly IHost _host;
        public App()
        {
            _host = Host
                .CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<MainWindow>(provider => new MainWindow { DataContext = provider.GetRequiredService<MainWindowViewModel>() });

                    services.AddSingleton<MainWindowViewModel>();
                    services.AddSingleton<NutritionViewModel>();
                    services.AddSingleton<MainMenuViewModel>();
                    services.AddSingleton<GeneralViewModel>();
                    services.AddSingleton<DietListViewModel>();

                    services.AddSingleton<InavigationService, NavigationService>();

                    services.AddSingleton<Func<Type, ViewModelBase>>(provider => viewModelType => (ViewModelBase)provider.GetRequiredService(viewModelType));

                    // Custom Services
                    services.AddSingleton<PeoplesDataBase>();
                    services.AddSingleton<DietBaseModel>();
                    // FireBaseAuthConfiguration
                    string json = File.ReadAllText("Config/FirebaseConfig.json");
                    FirebaseCredentials? firebaseCredentials = JsonConvert.DeserializeObject<FirebaseCredentials>(json);
                    services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig
                    {
                        ApiKey = firebaseCredentials?.FIREBASE_API_KEY,
                        AuthDomain = firebaseCredentials?.FIREBASE_AUTH_DOMAIN,
                        Providers = new FirebaseAuthProvider[]
                        {
                            new EmailProvider(),
                        }
                    }));
                    services.AddSingleton<IAuthService, FireBaseAuthService>();

                })
                .Build();

        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            var MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
