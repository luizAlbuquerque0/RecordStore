using MediatR;

namespace RecordStore.Application.Commands.AddRecord
{
    public class AddRecordCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }
        public int StoreId { get; set; }
        public int Stock { get; set; }
    }
}
