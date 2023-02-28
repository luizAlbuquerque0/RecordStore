using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Commands.GetCartItem
{
    public class GetCartItemByIdQuery : IRequest<CartItemViewModel>
    {
        public GetCartItemByIdQuery(int cartItemId)
        {
            CartItemId = cartItemId;
        }

        public int CartItemId { get; private set; }
    }
}
