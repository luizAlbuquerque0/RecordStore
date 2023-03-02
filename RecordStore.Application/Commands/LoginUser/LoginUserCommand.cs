using MediatR;
using RecordStore.Application.ViewModels;

namespace RecordStore.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUserViewModel>
    {
        public string Email { get;  set; }
        public string Password { get;  set; }
    }
}
