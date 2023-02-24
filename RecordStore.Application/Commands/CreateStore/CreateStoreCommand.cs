using MediatR;

namespace RecordStore.Application.Commands.CreateStore
{
    public class CreateStoreCommand : IRequest<Unit>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
