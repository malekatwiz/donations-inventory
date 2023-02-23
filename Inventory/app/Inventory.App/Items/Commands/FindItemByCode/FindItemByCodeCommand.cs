using MediatR;

namespace Inventory.App.Items.Commands.FindItem;
public class FindItemByCodeCommand : IRequest<FindItemByCodeCommandResponse>
{
    public string Barcode { get; init; }
}
