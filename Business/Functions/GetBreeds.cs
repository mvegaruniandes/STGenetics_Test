using DataAccess;
using Microsoft.Extensions.Configuration;
using Models.Dtos;

namespace Business.Functions
{
    public class GetBreeds
    {
        private DatabaseContext? _dbContext;
        private readonly IConfiguration _configuration;

        public GetBreeds(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<BreedDTO> GetAllBreeds()
        {
            try
            {
                string? conn = _configuration.GetConnectionString("DbSTGenetics");
                _dbContext = new DatabaseContext(conn);

                List<BreedDTO> breeds = _dbContext.breed.Select(b => new BreedDTO
                {
                    BreedId = b.BreedId,
                    BreedName = b.BreedName
                }).ToList();

                return breeds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
