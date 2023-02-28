using MediatR;
using RecordStore.Application.ViewModels;
using RecordStore.Core.Repositories;
using RecordStore.Core.Services;

namespace RecordStore.Application.Commands.LoginUser
{
    internal class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        public LoginUserCommandHandler(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }

        public async Task<LoginUserViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var user = await _userRepository.GetUserByEmailAndPasswordAsync(request.Email,passwordHash);

            var token = _authService.GenerateJWTToken(user.Email, user.Role);

            return new LoginUserViewModel(user.Email, token);
        }
    }
}
