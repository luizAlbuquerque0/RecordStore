using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecordStore.Application.Commands.CreateOrder;
using RecordStore.Application.Queries.GetAllOrders;
using RecordStore.Application.Queries.GetOrderById;

namespace RecordStore.API.Controllers
{
    [Route("api/orders")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var query = new GetOrderByIdQuery(id);
            var order = await _mediator.Send(query);
            return order == null ? NotFound() : Ok(order);
        }

        [HttpPost]
        [Authorize(Roles = "user")]
        public async Task<IActionResult> CrateOrder([FromBody] CreateOrderCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetOrderById), new { id = id }, command);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserOrders(int id)
        {
            var query = new GetAllUserOrdersQuery(id);

            var orders = await _mediator.Send(query);

            return Ok(orders);
        }
    }
}
