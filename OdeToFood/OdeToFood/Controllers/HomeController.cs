using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;

namespace OdeToFood.Controllers
{
    public class HomeController:Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
       
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentDate = DateTime.Now;

            return View(model);
        }

        public IActionResult Details(int id) {

            var restaurant = _restaurantData.Get(id);

            if (restaurant == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(restaurant);
            }
        }
    }
}
