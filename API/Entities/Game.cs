using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public required string Name { get; set; }

        [Required]
        [StringLength(5)]
        public required string Genre { get; set; } 

        [Required]
        [Range(1,100)]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        [Url]
        [StringLength(10)]
        public required string ImageUri { get; set; }
    }
}