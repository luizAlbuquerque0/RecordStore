using MediatR;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.UpdateRecord
{
    public class UpdateRecordCommandHandler : IRequestHandler<UpdateRecordCommand, Unit>
    {
        private readonly IRecordRepository _recordRepository;
        public UpdateRecordCommandHandler(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public async Task<Unit> Handle(UpdateRecordCommand request, CancellationToken cancellationToken)
        {
            await _recordRepository.UpdateRecordStockAsync(request.RecordId, request.Amout);
            return Unit.Value;
        }
    }
}
