using DotNetWithPostreSql.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWithPostreSql.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
