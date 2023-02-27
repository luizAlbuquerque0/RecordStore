using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecordStore.Application.Commands.AddCartItem;
using RecordStore.Application.Commands.CreateCart;
using RecordStore.Application.Queries.GetCart;

namespace RecordStore.API.Controllers
{
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CartController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCart(int id)
        {
            var query = new GetCartByIdQuery(id);
            var cart =  await _mediator.Send(query);

            return cart == null ? NotFound() : Ok(cart);
        }
        [HttpPost("{id}")]
        public async Task<IActionResult> CreateCart(int userId)
        {
            var command = new CreateCartCommand(userId);
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetCart), new { id = id }, command);
        }

        [HttpPost("item")]
        public async Task<IActionResult> AddCartItem([FromBody] AddCartItemCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetCart), new { id = id }, command);
        }
    }
}
