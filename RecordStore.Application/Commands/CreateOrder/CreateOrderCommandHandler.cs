using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Unit>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICartRepository _cartRepository;
        public CreateOrderCommandHandler(IOrderRepository orderRepository,ICartRepository cartRepository)
        {
            _orderRepository = orderRepository;
            _cartRepository = cartRepository;
        }
        public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var cart = await _cartRepository.GetCartAsync(request.CartId);
            var order = new Order(request.UserId, request.StoreId, request.CartId, request.TotalPrice);
            order.SetTotalCost(cart.TotalCost);
            await _orderRepository.CreateOrderAsync(order);
            return Unit.Value;
        }
    }
}
