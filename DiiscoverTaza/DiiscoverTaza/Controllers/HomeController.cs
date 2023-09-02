
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

  

            public IActionResult Art_Culture()
            {
                return View("Art_Culture");
            }

        public IActionResult festivals()
        {
            return View("festivals");
        }
        public IActionResult Gastronomy()
        {
            return View("Gastronomy");
        }
        public IActionResult Musical_Heritage()
        {
            return View("Musical_Heritage");
        }
        public IActionResult Traditional_Clothing()
        {
            return View("Traditional_Clothing");
        }

        public IActionResult Traditional_public_baths()
        {
            return View("Traditional_public_baths");
        }
        public IActionResult Vegetable_products()
        {
            return View("Vegetable_products");
        }
        public IActionResult weekly_sooks()
        {
            return View("weekly_sooks");
        }

        public IActionResult Youth_Center()
        {
            return View("Youth_Center");
        }
        public IActionResult Hotels()
        {
            return View("Hotels");
        }

        public IActionResult Agora_Complex()
        {
            return View("Agora_Complex");
        }
        public IActionResult Pyramides()
        {
            return View("Pyramides");
        } public IActionResult Organic_Garden()
        {
            return View("Organic_Garden");
        }
        public IActionResult tazekka_hotel()
        {
            return View("tazekka_hotel");
        }
        public IActionResult Gîte_Dayet_Chiker()
        {
            return View("Gîte_Dayet_Chiker");
        } public IActionResult Beautiful_house()
        {
            return View("Beautiful_house");
        }public IActionResult KONOUZ_HOUSE()
        {
            return View("KONOUZ_HOUSE");
        }
        public IActionResult AL_WAHDA_APARTMENT()
        {
            return View("AL_WAHDA_APARTMENT");
        }
        
        
        //[HttpPost]
        //public JsonResult SaveFormData([FromBody]FormulaireDatum formData)
        //  {
        // //using (var context = new AppDbContext())
        // //{
        // //    context.FormDatas.Add(formData);
        // //    context.SaveChanges();
        // //}

        // return Json(new { success = true });
        //  }
    }
}

