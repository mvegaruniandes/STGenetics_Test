using System.ComponentModel.DataAnnotations;

namespace Models.Data
{
    public class Breed
    {
        [Key]
        public int BreedId { get; set; }
        public string? BreedName { get; set; }
    }
}
