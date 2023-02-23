using Inventory.App.Items.Commands.FindItem;
using MediatR;

namespace Inventory.App.Items.Commands.FindItemByCode;
internal class FindItemByCodeCommandHandler : IRequestHandler<FindItemByCodeCommand, FindItemByCodeCommandResponse>
{
    public Task<FindItemByCodeCommandResponse> Handle(FindItemByCodeCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
