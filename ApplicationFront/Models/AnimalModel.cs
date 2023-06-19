using System.ComponentModel.DataAnnotations;

namespace ApplicationFront.Models
{
    public class AnimalModel
    {
        public int AnimalId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Required")]
        public int BreedId { get; set; }
        [Required(ErrorMessage = "Required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Required")]
        public string? Sex { get; set; }
        [Required(ErrorMessage = "Required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Required")]
        public bool Status { get; set; }
        public string? Photo { get; set; }
    }
}
