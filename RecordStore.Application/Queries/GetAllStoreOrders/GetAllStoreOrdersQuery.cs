using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetAllStoreOrders
{
    public class GetAllStoreOrdersQuery : IRequest<List<SymplifyedOrdersViewModel>>
    {
        public int StoreId { get; set; }
    }
}
