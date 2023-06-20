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

        public List<AnimalDTO>? GetAllAnimals()
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
                       BirthDate = Convert.ToDateTime(a.BirthDate),
                       Sex = a.Sex,
                       Price = Convert.ToDecimal(a.Price),
                       Status = Convert.ToBoolean(a.Status),
                       Photo = a.Photo,
                       BreedName = b.BreedName
                   }).ToList();

                return animals;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
