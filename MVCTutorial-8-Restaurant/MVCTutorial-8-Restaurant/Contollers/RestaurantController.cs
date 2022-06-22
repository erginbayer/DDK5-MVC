using Microsoft.AspNetCore.Mvc;
using MVCTutorial_8_Restaurant.Models.ORM;

namespace MVCTutorial_8_Restaurant.Contollers
{
    public class RestaurantController : Controller
    {
        RestaurantContext context = new RestaurantContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Restaurant restaurant)
        {
            context.Add(restaurant);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult List()
        {
            var restaurantList = context.Restaurants.ToList();
            return View(restaurantList);
        }

    }
}
