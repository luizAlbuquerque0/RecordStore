using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetAllOrders
{
    public class GetAllUserOrdersQuery : IRequest<List<SymplifyedRecordsViewModel>>
    {
        public int UserId { get;  set; }
    }
}
