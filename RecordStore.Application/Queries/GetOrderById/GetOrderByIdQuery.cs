using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetOrderById
{
    public class GetOrderByIdQuery : IRequest<OrderViewModel>
    {
        public GetOrderByIdQuery(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
    }
}
