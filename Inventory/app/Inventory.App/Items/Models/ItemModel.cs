namespace Inventory.App.Items.Models;
public class ItemModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public decimal Weight { get; set; }
    public string Barcode { get; set; }
}
