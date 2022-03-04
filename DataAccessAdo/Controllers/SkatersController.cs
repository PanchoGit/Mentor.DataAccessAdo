using Microsoft.AspNetCore.Mvc;
using MediatR;
using DataAccessAdo.Services.Queries;

namespace DataAccessAdo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkatersController : ControllerBase
    {
        private readonly IMediator mediator;

        public SkatersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await mediator.Send(new SkaterQuery()));
        }
    }
}
