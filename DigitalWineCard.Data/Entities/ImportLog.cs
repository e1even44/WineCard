using System.ComponentModel.DataAnnotations;

namespace DigitalWineCard.Data.Entities
{
    public class ImportLog
    {
        [Key]
        public int ImportId { get; set; }

        [Required]
        public int AdminId { get; set; }
        public Admin Admin { get; set; } = null!;

        [Required]
        public DateTime ImportDate { get; set; }

        [Required]
        public string FileName { get; set; } = string.Empty;

        [Required]
        public int ImportedWinesAmount { get; set; }
    }
}
