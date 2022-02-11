using AutoMapper;
using DataAccessAdo.Domains;
using DataAccessAdo.Dtos;

namespace DataAccessAdo.Mappers
{
    public class SkaterMapperProfile : Profile
    {
        public SkaterMapperProfile()
        {
            CreateMap<Skater, SkaterDto>();
        }
    }
}
