using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;

namespace SiemensECommerce.UI.Controllers
{
    public class CategoryController : Controller
    {
        SiemensECommerceContext context = new SiemensECommerceContext();
        public IActionResult Index()
        {
            CategoryManager categoryManager = new CategoryManager();    
            var categories = categoryManager.GetCategories();
            //var categories = context.Categories.ToList();
            return View(categories);
        }
    }
}
