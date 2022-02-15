using DataAccessAdo.Domains;

namespace DataAccessAdo.Repositories
{
    public interface ISkaterRepository
    {
        IEnumerable<Skater> GetAll();
    }
}
