using Microsoft.EntityFrameworkCore;
namespace AngularApp1.Server.Models
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {
        }

        //make physical data table with the model and use keyword "PaymentDetails" to query data in and out of table
        //build the database by using the command "Update-Database" in Package Manager Console 
        public DbSet<PaymentDetail> PaymentDetails { get; set; } = null!;
        
    }
}
