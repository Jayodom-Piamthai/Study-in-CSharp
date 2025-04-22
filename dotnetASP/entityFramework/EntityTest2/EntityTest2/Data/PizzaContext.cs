using Microsoft.EntityFrameworkCore;
using EntityTest2.Models;
using Microsoft.Extensions.Configuration;

namespace EntityTest2.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }
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

        public DbSet<Pizza> Pizzas { get; set; }
    }
}