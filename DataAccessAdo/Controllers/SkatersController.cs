using Microsoft.AspNetCore.Mvc;
using DataAccessAdo.Dtos;
using DataAccessAdo.Services;

namespace DataAccessAdo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkatersController : ControllerBase
    {
        private readonly ISkaterService service;

        public SkatersController(ISkaterService skaterService)
        {
            service = skaterService;
        }

        [HttpGet]
        public IEnumerable<SkaterDto> Get()
        {
            return service.GetAll();
        }
    }
}
