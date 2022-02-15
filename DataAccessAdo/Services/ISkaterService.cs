using DataAccessAdo.Dtos;

namespace DataAccessAdo.Services
{
    public interface ISkaterService
    {
        IEnumerable<SkaterDto> GetAll();
    }
}
