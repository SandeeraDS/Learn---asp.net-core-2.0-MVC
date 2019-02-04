using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class RestaurantListModel : PageModel
    {
        private IRestaurantData _restaurantData;

        public IEnumerable<Restaurant> RestaurantList { get; set; }

        public RestaurantListModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public void OnGet()
        {
            RestaurantList = _restaurantData.GetAll();
        }
    }
}