using DataAccessAdo.Domains;

namespace DataAccessAdo.Repositories
{
    public class SkaterRepository : ISkaterRepository
    {
        public IEnumerable<Skater> GetAll() {
            return new List<Skater>() {
                new()
                {
                    Id = 1,
                    Name = "Paul Rodriguez",
                    Brand = "Primitive"
                },
                new()
                {
                    Id = 2,
                    Name = "Tony Hawk",
                    Brand = "Bird"
                }
            };
        }
    }
}
