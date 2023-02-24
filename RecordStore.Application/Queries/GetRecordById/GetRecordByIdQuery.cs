using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Queries.GetRecordById
{
    public class GetRecordByIdQuery : IRequest<RecordViewModel>
    {
        public GetRecordByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
