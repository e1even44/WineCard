using System.ComponentModel.DataAnnotations;

namespace DigitalWineCard.Data.Entities
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [MaxLength(64)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Salt { get; set; } = string.Empty;
    }
}
