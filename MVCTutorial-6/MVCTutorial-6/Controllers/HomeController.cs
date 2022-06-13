using Microsoft.AspNetCore.Mvc;
using MVCTutorial_6.Models.ORM;

namespace MVCTutorial_6.Controllers
{
    public class HomeController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        
        [HttpGet]
        public IActionResult Index()
        {
            List<Supplier> supplierList = siemensContext.Suppliers.ToList();
            return View(supplierList);
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var idSup = siemensContext.Suppliers.FirstOrDefault(x => x.Id == id);
            return View(idSup);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Supplier suppliers)
        {

            siemensContext.Add(suppliers);
            siemensContext.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product products)
        {
            siemensContext.Add(products);
            siemensContext.SaveChanges();

            return View();
        }

        public IActionResult Product()
        {
            List<Product> products = siemensContext.Products.ToList();
            return View(products);
        }
    }
}
