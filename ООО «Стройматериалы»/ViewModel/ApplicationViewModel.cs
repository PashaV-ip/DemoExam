using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Стройматериалы_.DbEntity;

namespace ООО__Стройматериалы_.ViewModel
{
    public class ApplicationViewModel : BaseViewModel
    {
        private User _user;
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
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

        public bool CheckAdmin()
        {
            return User.RoleID == 1;
        }

        public void LoadData()
        {
            var productList = DbStorage.DB_s.Product.ToList();
            productList.ForEach(element => Products?.Add(element));
        }

        public void OpenAdminPanel()
        {
            //var adminPanel = new AdminPanelWindow(User);
            //adminPanel.Show();
        }

        public ApplicationViewModel(User user)
        {
            Products = new ObservableCollection<Product>();
            User = user;
            if (CheckAdmin())
            {
                OpenAdminPanel();
            }
            LoadData();
        }
    }
}
