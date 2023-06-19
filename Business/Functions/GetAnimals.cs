using DataAccess;
using Microsoft.Extensions.Configuration;
using Models.Dtos;

namespace Business.Functions
{
    public class GetAnimals
    {
        private DatabaseContext? _dbContext;
        private readonly IConfiguration _configuration;

        public GetAnimals(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<AnimalDTO> GetAllAnimals()
        {
            try
            {
                string? conn = _configuration.GetConnectionString("DbSTGenetics");
                _dbContext = new DatabaseContext(conn);


                List<AnimalDTO> animals = _dbContext.animal
                   .Join(_dbContext.breed,
                   a => a.BreedId,
                   b => b.BreedId,
                   (a, b) => new AnimalDTO
                   {
                       AnimalId = a.AnimalId,
                       BreedId = b.BreedId,
                       Name = a.Name,
                       BirthDate = a.BirthDate,
                       Sex = a.Sex,
                       Price = a.Price,
                       Status = a.Status,
                       Photo = a.Photo,
                       BreedName = b.BreedName
                   }).ToList();

                return animals;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
