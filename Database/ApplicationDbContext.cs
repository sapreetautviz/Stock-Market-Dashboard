using Microsoft.EntityFrameworkCore;

namespace Stock_Market_Dashboard.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

    }
}
