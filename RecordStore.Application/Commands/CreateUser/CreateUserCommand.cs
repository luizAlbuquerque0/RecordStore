using MediatR;

namespace RecordStore.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Unit>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
