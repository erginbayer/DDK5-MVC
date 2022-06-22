using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminSupplierController : AdminBaseController
    {
        public IActionResult Index()
        {
            SupplierManager supplierManager = new SupplierManager();
            var suppliers = supplierManager.GetSuppliers();        
            
            return View(suppliers);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(SupplierVM model)
        {
            if (ModelState.IsValid)
            {
                Supplier supplier = new Supplier();
                supplier.CompanyName = model.CompanyName;
                supplier.ContactName = model.ContactName;
                supplier.ContactTitle = model.ContactTitle;
                supplier.IsDeleted = false;
                supplier.AddDate = DateTime.Now;    
                SupplierManager.Add(supplier);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }
    }
}
