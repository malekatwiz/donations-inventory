namespace Inventory.App.Models;
public class ItemInputModel
{
    [Required, MinLength(3)]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required, MinLength(6)]
    public string BarCode { get; set; }
}
