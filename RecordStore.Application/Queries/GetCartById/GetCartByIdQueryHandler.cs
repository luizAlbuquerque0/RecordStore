using MediatR;
using RecordStore.Application.ViewModels;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Queries.GetCart
{
    public class GetCartByIdQueryHandler : IRequestHandler<GetCartByIdQuery, CartViewModel>
    {
        private readonly ICartRepository _cartRepository;
        public GetCartByIdQueryHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;

        }
        public async Task<CartViewModel> Handle(GetCartByIdQuery request, CancellationToken cancellationToken)
        {
          
            var cart = await _cartRepository.GetCartAsync(request.Id);
            if (cart == null) return null;
            var cartItens = cart.CartItem.Select(ci => new CartItemViewModel(ci.CartId, ci.RecordId, ci.Amount)).ToList();
            return new CartViewModel(cart.Id, cart.UserId, cartItens, cart.TotalCost);
        }
    }
}
