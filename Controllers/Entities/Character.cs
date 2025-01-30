using System.ComponentModel.DataAnnotations;

namespace STAR_WARS_API.Controllers.Entities
{
    public class Character
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string description { get; set; }
        [Required]
        public required string specie { get; set; }
        [Required]
        public required string Category { get; set; }
        [Required]
        public required string Weapon { get; set; }
        [Required]
        public required string Skill { get; set; }
        [Required]
        public required string Alliance { get; set; }
        [Required]
        public required string MovieSerie { get; set; }
        [Required]
        [Url]
        public required string Image { get; set; }
    }
}
