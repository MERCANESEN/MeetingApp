using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost/home
        //localhost
        //localhost/home/Index
        public string Index(){

            return "home/Index";
        }
    }
}