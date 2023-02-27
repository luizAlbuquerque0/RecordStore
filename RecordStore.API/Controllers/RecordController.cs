using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecordStore.Application.Commands.AddRecord;
using RecordStore.Application.Queries.GetOrderById;

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
            var query = new GetOrderByIdQuery(id);
            var record = _mediator.Send(query);
            return record == null ? NotFound() : Ok(record);   
        }

        [HttpPost]
        public async Task<IActionResult> AddRecord([FromBody] AddRecordCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}
