using Microsoft.EntityFrameworkCore;
using Stock_Market_Dashboard.Models;

namespace Stock_Market_Dashboard.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Watchlist> Watchlist { get; set; } 

    }
}
