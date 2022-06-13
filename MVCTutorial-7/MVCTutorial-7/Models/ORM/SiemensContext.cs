using Microsoft.EntityFrameworkCore;

namespace MVCTutorial_7.Models.ORM
{
    public class SiemensContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = MVC-WebUser ; Trusted_Connection = True;");
        }

        public DbSet<WebUser> WebUsers { get; set; }

    }
}
