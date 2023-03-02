using MediatR;

namespace RecordStore.Application.Commands.DeleteCart
{
    public class DeleteCartCommand : IRequest<Unit>
    {
        public DeleteCartCommand(int cartId)
        {
            CartId = cartId;
        }

        public int CartId { get; private set; }
    }
}
