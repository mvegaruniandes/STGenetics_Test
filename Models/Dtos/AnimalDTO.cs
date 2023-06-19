namespace Models.Dtos
{
    public class AnimalDTO
    {
        public int AnimalId { get; set; }
        public string? Name { get; set; }
        public int BreedId { get; set; }
        public string? BreedName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Sex { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public string? Photo { get; set; }
    }
}
