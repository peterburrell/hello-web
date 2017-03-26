using System;
using Microsoft.AspNetCore.Mvc;

namespace hello_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult About()
        {
            var about = new {
                now = DateTime.UtcNow,
                message = "I like 🍩s!"
            };

            return Json(about);
        }

        public IActionResult Contact()
        {
            return Content("this is a contact page");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
