using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Data
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Breed")]
        public int BreedId { get; set; }
        [Required]
        public Breed? Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Sex { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public string? Photo { get; set; }
    }
}
