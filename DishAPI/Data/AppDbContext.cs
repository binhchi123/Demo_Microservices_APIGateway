using DishAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace DishAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
    }
}
