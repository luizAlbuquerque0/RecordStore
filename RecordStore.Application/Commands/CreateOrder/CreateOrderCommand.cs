using MediatR;
using RecordStore.Core.Entities;

namespace RecordStore.Application.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<Unit>
    {
        public int UserId { get;  set; }
        public int StoreId { get;  set; }
        public int CartId { get;  set; }
        public decimal TotalPrice { get;  set; }
    }
}
