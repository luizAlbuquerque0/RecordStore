using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.AddRecord
{
    public class AddRecordCommandHandler : IRequestHandler<AddRecordCommand, int>
    {
        private readonly IRecordRepository _recordRepository;
        public AddRecordCommandHandler(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public async Task<int> Handle(AddRecordCommand request, CancellationToken cancellationToken)
        {
            var record = new Record(request.Name, request.Description, request.Gender, request.Price, request.StoreId, request.Stock);
            await _recordRepository.AddRecordAsync(record);
            return record.Id;
        }
    }
}
