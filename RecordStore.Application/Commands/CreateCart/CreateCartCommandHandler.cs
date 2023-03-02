using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.CreateCart
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, int>
    {
        private readonly ICartRepository _cartRepository;
        public CreateCartCommandHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public async Task<int> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            var cart = new Cart(request.UserId);
            await _cartRepository.CreateCartAsync(cart);
            return cart.Id;
        }
    }
}

