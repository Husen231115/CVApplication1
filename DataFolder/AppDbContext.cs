using Microsoft.EntityFrameworkCore;
using WebApplication9.DB_Model;

namespace WebApplication9.DataFolder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(){}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CV> Cv { get; set; }
    }
}
