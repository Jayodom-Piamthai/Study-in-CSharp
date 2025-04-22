using System.Configuration;
using AngularServer.Models;
using Microsoft.EntityFrameworkCore;
namespace AngularApp1.Models
{
    public class PaymentContext : DbContext
    {
        //for express sql server
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {
        }

        ////for postresql server
        //protected readonly IConfiguration Configuration;

        //public PaymentContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to postgres with connection string from app settings
        //    options.UseNpgsql(Configuration.GetConnectionString("PostgresConnection"));
        //}


        //make physical data table with the model and use keyword "PaymentDetails" to query data in and out of table
        //build the database by using the command "Update-Database" in Package Manager Console 
        public DbSet<PaymentDetail> PaymentDetails { get; set; } = null!;
    }
}
