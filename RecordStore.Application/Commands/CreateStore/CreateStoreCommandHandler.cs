using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Models;
using RecordStore.Core.Repositories;

namespace RecordStore.Application.Commands.CreateStore
{
    public class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        public CreateStoreCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Unit> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            var store = new User(request.FullName, request.Email, request.Password, request.Phone);
            store.setRole(UserRoles.user);

            await _userRepository.CreateUserAsync(store);

            return Unit.Value;
        }
    }
}
