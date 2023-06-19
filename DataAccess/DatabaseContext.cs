using Microsoft.EntityFrameworkCore;
using Models.Data;

namespace DataAccess
{
    public class DatabaseContext : DbContext
    {
        private readonly string? _connectionString;

        public DatabaseContext(string? connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public virtual DbSet<Animal> animal { get; set; }
        public virtual DbSet<Breed> breed { get; set; }

    }
}