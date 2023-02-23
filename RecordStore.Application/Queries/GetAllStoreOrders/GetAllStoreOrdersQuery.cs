using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetAllStoreOrders
{
    public class GetAllStoreOrdersQuery : IRequest<List<SymplifyedRecordsViewModel>>
    {
        public int StoreId { get; set; }
    }
}
