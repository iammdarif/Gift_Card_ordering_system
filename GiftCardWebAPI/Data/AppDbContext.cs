using GiftCardWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GiftCardWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<GiftCard>  GiftCards { get; set; }
        public DbSet<Person> Persons { get; set; }   

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
