using DataAccessAdo.Dtos;
using DataAccessAdo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataAccessAdo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkatersController : ControllerBase
    {
        private readonly SkaterService service;

        public SkatersController()
        {
            service = new SkaterService();
        }

        [HttpGet]
        public IEnumerable<SkaterDto> Get()
        {
            return service.GetAll();
        }
    }
}
