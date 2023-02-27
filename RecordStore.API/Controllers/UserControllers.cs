using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecordStore.Application.Commands.CreateStore;
using RecordStore.Application.Commands.CreateUser;
using RecordStore.Application.Queries.GetUserQuery;

namespace RecordStore.API.Controllers
{
        [Route("api/users")]
    public class UserControllers : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserControllers(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUserQuery(id);

            var user = await _mediator.Send(query);
            if (user == null) return NotFound();

            return Ok(new { user = user});
         
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
           
                var id = await _mediator.Send(command);


            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPost("store")]
        public async Task<IActionResult> CreateStore([FromBody] CreateStoreCommand command)
        {

            var id = await _mediator.Send(command);


            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}
