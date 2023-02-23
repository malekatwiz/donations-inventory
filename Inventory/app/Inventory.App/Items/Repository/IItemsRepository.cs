using Inventory.App.Items.Models;

namespace Inventory.App.Items.Repository;
public interface IItemsRepository
{
    Task<ItemModel> FindByBarCode(string barCode);
}
