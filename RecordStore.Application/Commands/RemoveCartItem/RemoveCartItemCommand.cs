using MediatR;

namespace RecordStore.Application.Commands.RemoveCartItem
{
    public class RemoveCartItemCommand : IRequest<Unit>
    {
        public RemoveCartItemCommand(int cartItemId)
        {
            CartItemId = cartItemId;
        }

        public int CartItemId { get; private set; }
    }
}
