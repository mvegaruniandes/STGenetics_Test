using System.ComponentModel.DataAnnotations;

namespace ApplicationFront.Models
{
    public class AnimalModel
    {
        public int AnimalId { get; set; }

        [Required(ErrorMessage = "The name is required")]
        [MaxLength(255)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Breed is required")]
        public int? BreedId { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime? BirthDate { get; set; }
        [Required(ErrorMessage = "Sex is required")]
        public string? Sex { get; set; }
        [Required(ErrorMessage = "The price is required")]        
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Status is required")]
        public bool? Status { get; set; }
        [MaxLength(255)]
        [Required(ErrorMessage = "Photo is required")]
        public string? Photo { get; set; }
    }
}
