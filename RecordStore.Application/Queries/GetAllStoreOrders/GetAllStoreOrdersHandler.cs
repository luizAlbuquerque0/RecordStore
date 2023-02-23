using MediatR;
using RecordStore.Application.ViewModels;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Queries.GetAllStoreOrders
{
    public class GetAllStoreOrdersHandler : IRequestHandler<GetAllStoreOrdersQuery, List<SymplifyedOrdersViewModel>>
    {
        private readonly IOrderRepository _orderRepository;
        public GetAllStoreOrdersHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<List<SymplifyedOrdersViewModel>> Handle(GetAllStoreOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetStoreOrdersAsync(request.StoreId);
            return orders.Select(o => new SymplifyedOrdersViewModel(o.Id, o.TotalPrice, o.Date)).ToList();
        }
    }
}
