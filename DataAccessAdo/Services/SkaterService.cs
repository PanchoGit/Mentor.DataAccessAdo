using AutoMapper;
using DataAccessAdo.Dtos;
using DataAccessAdo.Repositories;

namespace DataAccessAdo.Services
{
    public class SkaterService
    {
        private readonly SkaterRepository repository;
        public readonly IMapper mapper;

        public SkaterService(IMapper mapper)
        {
            this.mapper = mapper;
            repository = new SkaterRepository();
        }

        public IEnumerable<SkaterDto> GetAll()
        {
            var list = repository.GetAll();

            return mapper.Map<List<SkaterDto>>(list);
        }
    }
}
