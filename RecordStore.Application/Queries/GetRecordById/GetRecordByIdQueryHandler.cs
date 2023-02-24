using MediatR;
using RecordStore.Application.ViewModels;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Queries.GetRecordById
{
    public class GetRecordByIdQueryHandler : IRequestHandler<GetRecordByIdQuery, RecordViewModel>
    {
        private readonly IRecordRepository _recordRepository;
        public GetRecordByIdQueryHandler(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public async Task<RecordViewModel> Handle(GetRecordByIdQuery request, CancellationToken cancellationToken)
        {
            var record = await _recordRepository.GetRecordByIdAsync(request.Id);
            return new RecordViewModel(record.Name, record.Description, record.Gender, record.Price, record.StoreId,record.Stock, record.Store.FullName);
        }
    }
}
