using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
