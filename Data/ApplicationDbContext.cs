using Microsoft.EntityFrameworkCore;
using RazorPizza.Models;

namespace RazorPizza.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <PizzaOrderModel> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
    }
}
