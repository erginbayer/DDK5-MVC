using Microsoft.EntityFrameworkCore;

namespace MVCTutorial_6.Models.ORM
{
    public class SiemensContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = MVC ; Trusted_Connection = True;");
        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }    
    }
}
