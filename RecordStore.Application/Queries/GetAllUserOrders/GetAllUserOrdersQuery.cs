using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetAllOrders
{
    public class GetAllUserOrdersQuery : IRequest<List<SymplifyedOrdersViewModel>>
    {
        public int UserId { get;  set; }
    }
}
