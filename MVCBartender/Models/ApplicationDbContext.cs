using Microsoft.EntityFrameworkCore;

namespace MVCBartender.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    } // end ApplicationDbContext class
} // end MVCBartender.Models namespace
