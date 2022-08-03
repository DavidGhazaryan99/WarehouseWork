using Microsoft.EntityFrameworkCore;
using WarehouseWork.Models;

namespace WarehouseWork.Data
{
    public class WarehouseDbContext:DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Manufactured> Manufactureds { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
