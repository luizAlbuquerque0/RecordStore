using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecordStore.Application.Commands.AddRecord;
using RecordStore.Application.Commands.UpdateRecord;
using RecordStore.Application.Queries.GetOrderById;
using RecordStore.Application.Queries.GetRecordById;

namespace RecordStore.API.Controllers
{
    [Route("api/records")]
    public class RecordController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RecordController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetRecordByIdQuery(id);
            var record = await _mediator.Send(query);
            return record == null ? NotFound() : Ok(record);   
        }

        [HttpPost]
        public async Task<IActionResult> AddRecord([FromBody] AddRecordCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStock(int id, [FromBody] int amount)
        {
            var command = new UpdateRecordCommand(id, amount);
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
