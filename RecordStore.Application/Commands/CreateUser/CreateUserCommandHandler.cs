using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName,request.Email,request.Password,request.Phone);

            await _userRepository.CreateUserAsync(user);

            return Unit.Value;
        }
    }
}
