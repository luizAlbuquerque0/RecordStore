using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecordStore.Application.Commands.AddCartItem;
using RecordStore.Application.Commands.CreateCart;
using RecordStore.Application.Commands.DeleteCart;
using RecordStore.Application.Commands.GetCartItem;
using RecordStore.Application.Commands.RemoveCartItem;
using RecordStore.Application.Queries.GetCart;

namespace RecordStore.API.Controllers
{
    [Route("api/cart")]
    [Authorize]
    [Authorize(Roles = "user")]
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
        [HttpPost("{userId}")]
        public async Task<IActionResult> CreateCart(int userId)
        {
            var command = new CreateCartCommand(userId);
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetCart), new { id = id }, command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            try
            {
                var command = new DeleteCartCommand(id);
                await _mediator.Send(command);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("item/{id}")]
        public async Task<IActionResult> GetCartItem(int id)
        {
            var query = new GetCartItemByIdQuery(id);
            var cartItem = await _mediator.Send(query);
            return cartItem == null ? NotFound() : Ok(cartItem);
        }

        [HttpPost("item")]
        public async Task<IActionResult> AddCartItem([FromBody] AddCartItemCommand command)
        {
            try
            {
                var id = await _mediator.Send(command);
                return CreatedAtAction(nameof(GetCartItem), new { id = id }, command);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("item/{id}")]
        public async Task<IActionResult> RemoveCartItemById(int id)
        {
            try
            {
                var commmand = new RemoveCartItemCommand(id);
                await _mediator.Send(commmand);
                return NoContent();
            }
            catch (Exception)
            {

                return NotFound();
            }
        }
    }
}
