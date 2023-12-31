﻿using DataAccess;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Dtos;

namespace Business.Functions
{
    public class UpdateAnimal
    {
        private DatabaseContext? _dbContext;
        private readonly IConfiguration _configuration;

        public UpdateAnimal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool EditAnimal(AnimalDTO animal)
        {
            try
            {
                string? conn = _configuration.GetConnectionString("DbSTGenetics");
                _dbContext = new DatabaseContext(conn);


                Animal currentAnimal = new()
                {
                    AnimalId = animal.AnimalId,
                    Name = animal.Name,
                    BreedId = animal.BreedId,
                    BirthDate = animal.BirthDate,
                    Sex = animal.Sex,
                    Price = animal.Price,
                    Status = animal.Status,
                    Photo = animal.Photo
                };

                _dbContext.animal.Update(currentAnimal);
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
