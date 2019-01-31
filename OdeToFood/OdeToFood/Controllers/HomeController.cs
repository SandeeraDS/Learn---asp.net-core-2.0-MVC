using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
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

        public IActionResult Details(int id)
        {

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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditModel model)
        {

            if (ModelState.IsValid){
                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;

                newRestaurant = _restaurantData.Add(newRestaurant);

                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
            }
            else
            {
                return View();   
            }

          
        }
    }
}