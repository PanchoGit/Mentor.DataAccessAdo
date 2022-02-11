using DataAccessAdo.Dtos;

namespace DataAccessAdo.Services
{
    public class SkaterService
    {
        public IEnumerable<SkaterDto> GetAll()
        {
            return new List<SkaterDto>() {
                new SkaterDto
                {
                    Id = 1,
                    Name = "Paul Rodriguez",
                    Brand = "Primitive"
                },
                new SkaterDto
                {
                    Id = 2,
                    Name = "Tony Hawk",
                    Brand = "Powell Perralta"
                }
            };
        }
    }
}
