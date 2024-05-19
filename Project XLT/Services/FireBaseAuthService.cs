using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_XLT.Services
{
    interface IAuthService
    {
        FirebaseAuthClient AuthClient { get; }
        public Task<User> LogIn(string mail, string password);
        public void LogOut();
        public Task<User> Register(string mail, string password);
    }
    public class FireBaseAuthService : IAuthService
    {
        public FirebaseAuthClient AuthClient { get; set;}

        public FireBaseAuthService(FirebaseAuthClient authClient)
        {
            AuthClient = authClient;
        }

        public async Task<User> LogIn(string mail, string password)
        {
            try
            {
                var UserCredentials = await AuthClient.SignInWithEmailAndPasswordAsync(mail, password);
                return UserCredentials.User;
            }
            catch
            {
                MessageBox.Show("Пользователь с такими данными не найден!");
                return null;
            }
        }

        public void LogOut()
        {
             AuthClient.SignOut();
        }

        public async Task<User> Register(string mail, string password)
        {
            try
            {
                var UserCredentials = await AuthClient.CreateUserWithEmailAndPasswordAsync(mail, password);
                return UserCredentials.User;
            }
            catch
            {
                MessageBox.Show("Пользователь с такимми данными уже существует!");
                return null;
            }

        }
    }
}
