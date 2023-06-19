using DataAccess;
using Microsoft.Extensions.Configuration;
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
            return false;        
        }
    }
}
