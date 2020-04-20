using BiologicPass.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiologicPass.Data
{
    public class BiologicPassDbContext : DbContext
    {
       public DbSet<Location> Locations { get; set; }

        public BiologicPassDbContext(DbContextOptions<BiologicPassDbContext> options) : base(options)
        {
            
        }
    }
}
