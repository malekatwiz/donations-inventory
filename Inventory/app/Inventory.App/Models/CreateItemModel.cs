namespace Inventory.App.Models
{
    public class CreateItemModel
    {
        [Required, MinLength(3)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public string BarCode { get; set; }

        public string Category { get; set; }

        [Required]
        public decimal Weight { get; set; }

        [Required]
        public string WeightUnit { get; set; }
    }
}
