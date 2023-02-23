using Inventory.App.Data;
using Inventory.App.Items.Models;

namespace Inventory.App.Items.Repository;
public class ItemsRepository : IItemsRepository
{
    private readonly InventoryDbContext _dbContext;

	public ItemsRepository(InventoryDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task AddItemAsync(ItemModel item, CancellationToken cancellationToken)
	{
		_dbContext.Items.Add(item);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

    public Task<ItemModel> FindByBarCode(string barCode)
    {
        throw new NotImplementedException();
    }
}
