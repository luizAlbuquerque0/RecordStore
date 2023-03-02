using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetAllOrders
{
    public class GetAllUserOrdersQuery : IRequest<List<SymplifyedOrdersViewModel>>
    {
        public GetAllUserOrdersQuery(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; private set; }
    }
}
