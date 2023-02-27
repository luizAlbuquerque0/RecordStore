using MediatR;
using Microsoft.AspNetCore.Mvc;
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
    }
}
