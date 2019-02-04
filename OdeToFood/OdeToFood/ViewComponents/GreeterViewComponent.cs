using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewComponents
{
    public class GreeterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = "Uthpala";
            return View("Default",model);
        }

    }
}
