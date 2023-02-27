using MediatR;
using RecordStore.Application.ViewModels;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.GetCartItem
{
    public class GetCartItemByIdQueryHandler : IRequestHandler<GetCartItemByIdQuery, CartItemViewModel>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public GetCartItemByIdQueryHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        public async Task<CartItemViewModel> Handle(GetCartItemByIdQuery request, CancellationToken cancellationToken)
        {
            var cartItem = await _cartItemRepository.GetCartItemByIdAsync(request.CartItemId);

            return cartItem == null ? null : new CartItemViewModel(cartItem.CartId, cartItem.RecordId, cartItem.Amount);
        }
    }
}
