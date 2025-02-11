using System.ComponentModel.DataAnnotations;

namespace STAR_WARS_API.Controllers.Entities
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required DateOnly Birth_Date { get; set; }
        [Required]
        public required string nationality { get; set; }
        [Required]
        public required string biography { get; set; }
        [Required]
        [Url]
        public required string ImageUrl { get; set; }
    }
}
