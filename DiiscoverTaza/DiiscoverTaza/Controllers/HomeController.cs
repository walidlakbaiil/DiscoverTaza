using DiiscoverTaza.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DiiscoverTaza.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

      
    }
}