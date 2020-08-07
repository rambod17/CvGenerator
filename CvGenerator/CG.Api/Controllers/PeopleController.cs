using CG.Core.Person.Commands;
using CG.Core.Person.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CG.Api.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PeopleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddNew([FromBody]AddNewPersonCommand addNewPersonCommand)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(addNewPersonCommand));
        }

        [HttpGet("{personId}")]
        public async Task<IActionResult> Get(int personId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(new GetPersonByIdQuery(personId)));
        }
    }
}
