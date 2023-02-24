using Inventory.Backend.Data.Entities;

namespace Inventory.Backend.Abstraction
{
    public interface IItemsOperations
    {
        ItemEntity GetItemByBarCode(string barCode);
        IEnumerable<ItemEntity> GetItems();
        bool CreateItem(ItemEntity item);
        Task<ProductLookupResults> BarCodeLookup(string barCode, CancellationToken cancellationToken = default);
    }
}
