using Inventory.Backend.Abstraction;
using Inventory.Backend.Data.Database;
using Inventory.Backend.Data.Entities;

namespace Inventory.Backend
{
    public class ItemsOperations : IItemsOperations
    {
        private readonly InventoryDbContext _dbContext;
        private readonly HttpClient _httpClient;

        public ItemsOperations(InventoryDbContext dbContext,
            IHttpClientFactory httpClientFactory)
        {
            _dbContext = dbContext;
            _httpClient = httpClientFactory.CreateClient(nameof(ItemsOperations));
        }

        public ItemEntity GetItemByBarCode(string barCode)
        {
            return _dbContext.Items.Where(x => x.BarCode == barCode).FirstOrDefault();
        }

        public IEnumerable<ItemEntity> GetItems()
        {
            return _dbContext.Items;
        }

        public bool CreateItem(ItemEntity item)
        {
            _dbContext.Items.Add(item);
            return _dbContext.SaveChanges() > 0;
        }

        public async Task<ProductLookupResults> BarCodeLookup(string barCode, CancellationToken cancellationToken)
        {
            ArgumentException.ThrowIfNullOrEmpty(nameof(barCode));
            var response = await _httpClient.GetAsync($"https://api.barcodelookup.com/v3/products?barcode={barCode}&formatted=y&key=apikey", cancellationToken);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonConvert.DeserializeObject<ProductLookupResults>(responseContent);
        }
    }

    public record ProductLookupResults
    {
        [JsonProperty("products")]
        public List<ProductResult> Products { get; set; } = new();
    }

    public record ProductResult
    {
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("barcode_number")]
        public string BarCode { get; set; } = string.Empty;

        [JsonProperty("images")]
        public List<string> Images { get; set; } = new();

        [JsonProperty("size")]
        public string Size { get; set; } = string.Empty;

        [JsonProperty("category")]
        public string Category { get; set; } = string.Empty;

        [JsonProperty("brand")]
        public string Brand { get; set; } = string.Empty;

        [JsonProperty("weight")]
        public string Weight { get; set; } = string.Empty;
    }
}
