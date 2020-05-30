using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinApp.Models;
using XamarinApp.Repositories;

namespace XamarinApp.ViewModel
{
    public class RestaurantsPageViewModel: BaseViewModel
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


        public ObservableCollection<RestaurantModel> Restaurantes { get; set; }



        public RestaurantsPageViewModel()
        {
            Restaurantes = new ObservableCollection<RestaurantModel>();
            LoadRestaurants();            

            /*
           Restaurantes = new List<RestaurantModel>();           

           Restaurantes.Add(new RestaurantModel
           {
               Id = Guid.NewGuid(),
               Nombre = "Kaskitos",
               Direccion = "Caldas",
               Telefono = "3214569874",
               Imagen = "https://media-cdn.tripadvisor.com/media/photo-s/15/47/48/a9/la-letra-b-insignia-de.jpg",
               SitioWeb = "www.pillalo.co"
           });
           Restaurantes.Add(new RestaurantModel
           {
               Id = Guid.NewGuid(),
               Nombre = "Empanadas doña Martha",
               Direccion = "Caldas",
               Telefono = "3214569874",
               Imagen = "https://media-cdn.tripadvisor.com/media/photo-s/17/a0/bb/85/t-bone-steak.jpg",
               SitioWeb = "www.pillalo.co"
           });
           Restaurantes.Add(new RestaurantModel
           {
               Id = Guid.NewGuid(),
               Nombre = "Kaskitos",
               Direccion = "Caldas",
               Telefono = "3214569874",
               Imagen = "https://media-cdn.tripadvisor.com/media/photo-s/15/47/48/a9/la-letra-b-insignia-de.jpg",
               SitioWeb = "www.pillalo.co"
           });
           Restaurantes.Add(new RestaurantModel
           {
               Id = Guid.NewGuid(),
               Nombre = "Empanadas doña Martha",
               Direccion = "Caldas",
               Telefono = "3214569874",
               Imagen = "https://media-cdn.tripadvisor.com/media/photo-s/17/a0/bb/85/t-bone-steak.jpg",
               SitioWeb = "www.pillalo.co"
           });
           */

              

        }
        async private void LoadRestaurants()
        {
            IsRefreshing = true;
            foreach (var item in await new RestaurantRepository().GetRestaurants())

            {
                Restaurantes.Add(item);                

            }

            IsRefreshing = false;
        }


    }
}
