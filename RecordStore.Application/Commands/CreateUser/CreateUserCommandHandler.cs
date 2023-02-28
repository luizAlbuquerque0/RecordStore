using MediatR;
using RecordStore.Core.Entities;
using RecordStore.Core.Models;
using RecordStore.Core.Repositories;
using RecordStore.Core.Services;

namespace RecordStore.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        public CreateUserCommandHandler(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var user = new User(request.FullName,request.Email, passwordHash, request.Phone);
            user.setRole(UserRoles.user);

            await _userRepository.CreateUserAsync(user);

            return user.Id;
        }
    }
}
