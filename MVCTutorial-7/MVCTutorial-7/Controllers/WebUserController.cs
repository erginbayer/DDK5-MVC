using Microsoft.AspNetCore.Mvc;
using MVCTutorial_7.Models.ORM;

namespace MVCTutorial_7.Controllers
{
    public class WebUserController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        public IActionResult Index()
        {
            List<WebUser> webUsers = siemensContext.WebUsers.ToList();
            return View(webUsers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(WebUser user)
        {
            siemensContext.Add(user);
            siemensContext.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
