using DataAccessAdo.Domains;

namespace DataAccessAdo.Repositories
{
    public class SkaterRepository
    {
        public IEnumerable<Skater> GetAll() {
            return new List<Skater>() {
                new Skater
                {
                    Id = 1,
                    Name = "Paul Rodriguez",
                    Brand = "Primitive"
                },
                new Skater
                {
                    Id = 2,
                    Name = "Tony Hawk",
                    Brand = "Bird"
                }
            };
        }
    }
}
