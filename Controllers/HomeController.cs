using MeetingApp.Models;
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
            //ViewData["UserName"]= "Mercan";

            var meetingInfo = new MeetingInfo()  {
                Id=1,
                Location= "İstanbul, Abc Kongre Merkezi",
                Date= new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople= 100

            };
            return View(meetingInfo);
        }
    }
}