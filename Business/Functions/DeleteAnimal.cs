using DataAccess;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Functions
{
    public class DeleteAnimal
    {
        private DatabaseContext? _dbContext;
        private readonly IConfiguration _configuration;

        public DeleteAnimal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool RemoveAnimal(AnimalDTO animal)
        {
            try
            {
                string? conn = _configuration.GetConnectionString("DbSTGenetics");
                _dbContext = new DatabaseContext(conn);


                Animal currentAnimal = new()
                {
                    AnimalId = animal.AnimalId
                };

                _dbContext.animal.Remove(currentAnimal);
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
