using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetCart
{
    public class GetCartByIdQuery : IRequest<CartViewModel>
    {
        public GetCartByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

    }
}
