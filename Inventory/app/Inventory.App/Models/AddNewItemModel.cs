using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Inventory.App.Models;
public class AddNewItemModel
{
    public ItemInputModel Data { get; set; }

    [Parameter]
    public RenderFragment? TableHeader { get; set; }

    [Parameter]
    public RenderFragment<ItemInputModel>? RowTemplate { get; set; }

    [Parameter, AllowNull]
    public IReadOnlyList<ItemInputModel> Items { get; set; }
}
