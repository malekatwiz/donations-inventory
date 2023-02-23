using Inventory.App.Items.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.App.Data;

public class InventoryDbContext : DbContext
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options) :base(options)
    {
    }

    public DbSet<ItemModel> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemModel>(e =>
        {
            e.ToTable("Items");
            e.HasKey("Id");
        });
    }
}
