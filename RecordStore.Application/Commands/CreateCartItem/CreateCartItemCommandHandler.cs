using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.CreateCartItem
{
    public class CreateCartItemCommandHandler : IRequestHandler<CreateCartItemCommand, int>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public CreateCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<int> Handle(CreateCartItemCommand request, CancellationToken cancellationToken)
        {
            var cartItem = new CartItem(request.CartId, request.RecordId, request.Amount);
            await _cartItemRepository.CreateCartItemAsync(cartItem);

            return cartItem.Id;
        }
    }
}
