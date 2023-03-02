using MediatR;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.DeleteCart
{
    public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, Unit>
    {
        private readonly ICartRepository _cartRepository;
        public DeleteCartCommandHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public async Task<Unit> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            await _cartRepository.DeleteCartAsync(request.CartId);
            return Unit.Value;
        }
    }
}
