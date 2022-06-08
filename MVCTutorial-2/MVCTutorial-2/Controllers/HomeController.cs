using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
