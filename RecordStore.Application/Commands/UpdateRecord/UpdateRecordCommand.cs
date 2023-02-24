using MediatR;

namespace RecordStore.Application.Commands.UpdateRecord
{
    public class UpdateRecordCommand : IRequest<Unit>
    {
        public UpdateRecordCommand(int recordId, int amout)
        {
            RecordId = recordId;
            Amout = amout;
        }

        public int RecordId { get; private set; }
        public int Amout { get; private set; }
    }
}
