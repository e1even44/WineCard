using System.ComponentModel;

namespace DigitalWineCard.Data.UI.UIDtos
{
    public class WineUiDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [DisplayName("Origin Country")]
        public string CountryOfOrigin { get; set; } = string.Empty;

        public int Year { get; set; }

        [DisplayName("Liter Price in €")]
        public double LiterPriceInEuro { get; set; }
    }
}
