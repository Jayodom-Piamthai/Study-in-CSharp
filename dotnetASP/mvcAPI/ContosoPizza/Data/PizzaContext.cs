    using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;
namespace ContosoPizza.Data
{
    public class PizzaContext(DbContextOptions<PizzaContext> options) : DbContext(options)
    {
        public DbSet<Pizza> SetPizza => Set<Pizza>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pizza>().HasData(
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true },
            new Pizza { Id = 3, Name = "Hawaiian", IsGlutenFree = false },
            new Pizza { Id = 4, Name = "Extreme Cheese", IsGlutenFree = true }
            );
        }
    }
}