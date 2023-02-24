namespace Inventory.Backend.Data.Entities
{
    public class ItemEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnit { get; set; }
        public string BarCode { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
