using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public string GetName()
        {
            return "Mehmet Bayer";
        }
    }
}
