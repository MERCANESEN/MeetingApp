using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(){

            int saat= DateTime.Now.Hour;
            
            //ViewBag.Selamlama = saat > 12 ? "İyi Günler":"Günaydın";
            // ViewBag.UserName = "Mercan";

            ViewData["Selamlama"]= saat > 12 ? "İyi Günler":"Günaydın";
            ViewData["UserName"]= "Mercan";
            return View();
        }
    }
}