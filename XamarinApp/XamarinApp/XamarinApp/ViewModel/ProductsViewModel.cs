using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinApp.Models;
using XamarinApp.Repositories;

namespace XamarinApp.ViewModel
{
    public class ProductsViewModel: BaseViewModel
    {

        private bool _IsRefreshing;

        public bool IsRefreshing
        {
            get { return _IsRefreshing; }
            set
            {
                _IsRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            }
        }

        public List<ProductsModel> Productos { get; set; }

        public ProductsViewModel (RestaurantModel Item)
        {              
        }        

        

    }
}
