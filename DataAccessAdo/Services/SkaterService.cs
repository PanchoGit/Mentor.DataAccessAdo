using AutoMapper;
using DataAccessAdo.Dtos;
using DataAccessAdo.Repositories;

namespace DataAccessAdo.Services
{
    public class SkaterService : ISkaterService
    {
        private readonly ISkaterRepository repository;
        private readonly IMapper mapper;

        public SkaterService(IMapper mapper, ISkaterRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public IEnumerable<SkaterDto> GetAll()
        {
            var list = repository.GetAll();

            return mapper.Map<List<SkaterDto>>(list);
        }
    }
}
