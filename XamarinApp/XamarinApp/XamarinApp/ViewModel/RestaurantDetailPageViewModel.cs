using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinApp.Models;
using XamarinApp.Repositories;

namespace XamarinApp.ViewModel
{
    public class RestaurantDetailPageViewModel: BaseViewModel
    {
        public RestaurantModel Item { get; set; }
        public ObservableCollection<ProductsModel> Products { get; set; }

        public RestaurantDetailPageViewModel(RestaurantModel item)
        {
            Item = item;

            Products = new ObservableCollection<ProductsModel>();
            LoadProducts(Item);
        }

        async public void LoadProducts(RestaurantModel Item)
        {             
            foreach (var item in await new RestaurantRepository().GetProducts(Item.Id))
            {
                Products.Add(item);

            }
        }
    }
}
