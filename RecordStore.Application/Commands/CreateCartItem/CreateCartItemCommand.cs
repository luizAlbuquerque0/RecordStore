using MediatR;

namespace RecordStore.Application.Commands.CreateCartItem
{
    public class CreateCartItemCommand : IRequest<int>
    {

        public int CartId { get;  set; }
        public int RecordId { get;  set; }
        public int Amount { get;  set; }
    }
}
