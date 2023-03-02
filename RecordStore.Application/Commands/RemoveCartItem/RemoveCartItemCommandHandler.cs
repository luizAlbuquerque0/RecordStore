using MediatR;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.RemoveCartItem
{
    public class RemoveCartItemCommandHandler : IRequestHandler<RemoveCartItemCommand, Unit>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public RemoveCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<Unit> Handle(RemoveCartItemCommand request, CancellationToken cancellationToken)
        {
            await _cartItemRepository.RemoveCartItemAsync(request.CartItemId);
            return Unit.Value;
        }
    }
}
