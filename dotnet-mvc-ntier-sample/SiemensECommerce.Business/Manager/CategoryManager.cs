using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class CategoryManager
    {
        public List<Category> GetCategories()
        {
            SiemensECommerceContext context = new SiemensECommerceContext();
            var categories = context.Categories.ToList();
            return categories;
        }
        public Category GetCategoryById(int id)
        {
            SiemensECommerceContext context = new SiemensECommerceContext();
            var category = context.Categories.FirstOrDefault(c => c.Id == id);
            return category;
        }

        public void Add(Category category)
        {
            SiemensECommerceContext context = new SiemensECommerceContext();
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            SiemensECommerceContext context = new SiemensECommerceContext();
            var category = context.Categories.FirstOrDefault(c => c.Id == id);
            category.IsDeleted = true;
            context.SaveChanges();
        }
    }
}
