using Inventory.Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Backend.Data.Database
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext() :base(new DbContextOptionsBuilder<InventoryDbContext>()
            .UseInMemoryDatabase("inventoryDb")
            .Options)
        {
        }

        public DbSet<ItemEntity> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemEntity>(e =>
            {
                e.ToTable("Items");
                e.HasKey(e => e.Id);
            });
        }
    }
}
