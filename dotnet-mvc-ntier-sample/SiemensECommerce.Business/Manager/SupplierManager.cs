using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class SupplierManager
    {
        public static void Add(Supplier supplier)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }     

        public List<Supplier> GetSuppliers()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var suppliers = db.Suppliers.Where(q=>q.IsDeleted==false).ToList();
            return suppliers;
        }
    }
}
