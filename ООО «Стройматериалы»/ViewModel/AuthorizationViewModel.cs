using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ООО__Стройматериалы_.DbEntity;
using ООО__Стройматериалы_.View.Windows;

namespace ООО__Стройматериалы_.ViewModel
{
    public class AuthorizationViewModel : BaseViewModel
    {
        private string _password;
        private string _login;
        private User _user;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public User User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }
        private async Task<bool> Validation(string login, string password)
        {
            try
            {

                var result = await DbStorage.DB_s.User.FirstOrDefaultAsync(user => user.UserLogin == login &&user.UserPassword == password);

                _user = result;

                if (result != null)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Необработанное исключение",
                        MessageBoxButton.OK, MessageBoxImage.Stop);

                return false;
            }
        }

        public async void Auntification()
        {
            if(await Validation(Login, Password))
            {
                MessageBox.Show("Вы успешно авторизировались", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                ApplicationWindow window = new ApplicationWindow(User);
                window.Show();
                foreach(var item in App.Current.Windows)
                {
                    if(item is MainWindow)
                    {
                        (item as MainWindow).Hide();
                    }
                }
                return;
            }
            MessageBox.Show("Неверный логин или пароль", "Ошибка..", MessageBoxButton.OK, MessageBoxImage.Stop);
        }
    }
}
