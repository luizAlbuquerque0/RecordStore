using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Models;
using RecordStore.Core.Repositories;
using RecordStore.Core.Services;

namespace RecordStore.Application.Commands.CreateStore
{
    public class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        public CreateStoreCommandHandler(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }
        public async Task<Unit> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var store = new User(request.FullName, request.Email, passwordHash, request.Phone);
            store.setRole(UserRoles.user);

            await _userRepository.CreateUserAsync(store);

            return Unit.Value;
        }
    }
}
