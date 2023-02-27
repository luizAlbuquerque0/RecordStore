using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Unit>
    {
        private readonly IOrderRepository _orderRepository;
        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(request.UserId, request.StoreId, request.CardId, request.TotalPrice);
            await _orderRepository.CreateOrderAsync(order);
            return Unit.Value;
        }
    }
}
