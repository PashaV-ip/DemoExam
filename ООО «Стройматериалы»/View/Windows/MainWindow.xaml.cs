using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ООО__Стройматериалы_.DbEntity;
using ООО__Стройматериалы_.ViewModel;

namespace ООО__Стройматериалы_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new AuthorizationViewModel();
        }

        private void Buttons_Click(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Name)
            {
                case "buttonEnter":
                    (DataContext as AuthorizationViewModel).Password = passwordBoxUserPassword.Password;
                    (DataContext as AuthorizationViewModel).Auntification();
                    break;
                case "buttonExit":

                    break;
            }
        }
    }
}
