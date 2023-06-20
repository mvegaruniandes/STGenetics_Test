using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Dtos;

namespace Business.Functions
{
    public class CreateAnimal
    {
        private DatabaseContext? _dbContext;
        private readonly IConfiguration _configuration;

        public CreateAnimal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AddAnimal(AnimalDTO animal)
        {
            try
            {
                string? conn = _configuration.GetConnectionString("DbSTGenetics");
                _dbContext = new DatabaseContext(conn);


                Animal newAnimal = new()
                {
                    Name = animal.Name,
                    BreedId = animal.BreedId,
                    BirthDate = animal.BirthDate,
                    Sex = animal.Sex,
                    Price = animal.Price,
                    Status = animal.Status,
                    Photo = animal.Photo
                };

                _dbContext.animal.Add(newAnimal);
                _dbContext.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
