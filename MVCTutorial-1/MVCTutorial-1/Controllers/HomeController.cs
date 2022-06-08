using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
