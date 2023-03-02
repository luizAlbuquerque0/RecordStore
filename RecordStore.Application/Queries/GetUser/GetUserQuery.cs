using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetUserQuery
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public GetUserQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
