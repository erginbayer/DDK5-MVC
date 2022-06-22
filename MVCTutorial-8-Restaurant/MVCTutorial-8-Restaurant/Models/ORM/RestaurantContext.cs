using Microsoft.EntityFrameworkCore;

namespace MVCTutorial_8_Restaurant.Models.ORM
{
    public class RestaurantContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = MVC-RestaurantMVC ; Trusted_Connection = True;");
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
