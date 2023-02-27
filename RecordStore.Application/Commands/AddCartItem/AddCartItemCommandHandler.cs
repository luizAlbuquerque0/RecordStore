using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.AddCartItem
{
    public class AddCartItemCommandHandler : IRequestHandler<AddCartItemCommand, int>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public AddCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<int> Handle(AddCartItemCommand request, CancellationToken cancellationToken)
        {
            var cartItem = new CartItem(request.CartId, request.RecordId, request.Amount);
             await _cartItemRepository.CreateCartItemAsync(cartItem);

            return cartItem.Id;
        }
    }
}
