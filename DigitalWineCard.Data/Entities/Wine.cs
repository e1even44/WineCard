using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DigitalWineCard.Data.Entities
{
    public class Wine
    {
        [Key]
        public int WineId { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(64)]
        public string Type { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(64)]
        public string CountryOfOrigin { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public double LiterPriceInEuro { get; set; }

        [AllowNull]
        public int? ImportId { get; set; }
        public ImportLog? Import { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
