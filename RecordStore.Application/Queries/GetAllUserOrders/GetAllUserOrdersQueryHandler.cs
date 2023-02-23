using MediatR;
using RecordStore.Application.ViewModels;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Queries.GetAllOrders
{
    public class GetAllUserOrdersQueryHandler : IRequestHandler<GetAllUserOrdersQuery, List<SymplifyedOrdersViewModel>>
    {
        private readonly IOrderRepository _oderRepository;
        public GetAllUserOrdersQueryHandler(IOrderRepository orderRepository)
        {
            _oderRepository = orderRepository;
        }
        public async Task<List<SymplifyedOrdersViewModel>> Handle(GetAllUserOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _oderRepository.GetUserOrdersAsync(request.UserId);
            return orders.Select(o => new SymplifyedOrdersViewModel(o.Id,o.TotalPrice, o.Date)).ToList();
        }
    }
}
