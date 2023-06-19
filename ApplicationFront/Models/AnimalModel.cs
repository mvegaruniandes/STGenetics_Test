using Models.Dtos;

namespace ApplicationFront.Models
{
    public class AnimalModel
    {
        public List<AnimalDTO> Animals { get; set; }

        //Pagination
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int? PagerCount { get; set; }

    }
}
