using Inventory.Backend.Abstraction;
using Inventory.Backend.Data.Database;

namespace Inventory.Backend
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            return services.AddDbContext<InventoryDbContext>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddSingleton<IItemsOperations, ItemsOperations>()
                .AddHttpClient(nameof(ItemsOperations))
                .Services;
        }
    }
}
