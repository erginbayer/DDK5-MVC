using Microsoft.AspNetCore.Mvc;
using MVCTutorial_4.Models;

namespace MVCTutorial_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>(); 
            
            Product product1 = new Product("Televizyon", 2500,2200);
            Product product2 = new Product("Masaüstü Bilgisayar", 2300, 1800);
            Product product3 = new Product("Telefon", 1500, 1250);
            Product product4 = new Product("Kulaklık", 1100, 980);
            Product product5 = new Product("USB", 150, 130);
            Product product6 = new Product("Mouse", 250, 220);
            Product product7 = new Product("Akıllı Saat", 1500, 1350);
            Product product8 = new Product("Şarj Aleti", 50, 35);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);
            products.Add(product8);

            return View(products);
        }
    }
}
