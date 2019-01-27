using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurant()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1,Name="Uthpala's Pizza"},
                new Restaurant{Id=2,Name="Pizza Hut"},
                new Restaurant{Id=3 ,Name="Athur's Pizza"}
            };
        }

        

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}
