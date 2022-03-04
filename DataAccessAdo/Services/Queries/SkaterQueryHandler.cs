using AutoMapper;
using DataAccessAdo.Dtos;
using DataAccessAdo.Repositories;
using MediatR;

namespace DataAccessAdo.Services.Queries
{
    public class SkaterQueryHandler : IRequestHandler<SkaterQuery, SkaterQueryResponse>
    {
        private readonly ISkaterRepository repository;
        private readonly IMapper mapper;

        public SkaterQueryHandler(ISkaterRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<SkaterQueryResponse> Handle(SkaterQuery request, CancellationToken cancellationToken)
        {
            var list = repository.GetAll();

            return new SkaterQueryResponse
            {
                Skaters = mapper.Map<List<SkaterDto>>(list)
            };
        }
    }
}
