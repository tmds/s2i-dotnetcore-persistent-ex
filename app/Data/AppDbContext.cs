using Microsoft.EntityFrameworkCore;

namespace RazorPagesContacts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }

    public class MssqlDbContext : AppDbContext
    {
        public MssqlDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}