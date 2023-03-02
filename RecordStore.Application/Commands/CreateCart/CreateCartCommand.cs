using MediatR;

namespace RecordStore.Application.Commands.CreateCart
{
    public class CreateCartCommand : IRequest<int>
    {
        public CreateCartCommand(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; private  set; }
    }
}
