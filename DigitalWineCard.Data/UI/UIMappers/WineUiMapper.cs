using DigitalWineCard.Data.Entities;
using DigitalWineCard.Data.UI.UIDtos;

namespace DigitalWineCard.Data.UI.UIMappers
{
    public class WineUiMapper
    {
        public static WineUiDto ToDto(Wine wine)
        {
            return new WineUiDto
            {
                Id = wine.WineId,
                Name = wine.Name,
                Type = wine.Type,
                Description = wine.Description,
                CountryOfOrigin = wine.CountryOfOrigin,
                Year = wine.Year,
                LiterPriceInEuro = wine.LiterPriceInEuro
            };
        }

        public static List<WineUiDto> ToDto(List<Wine> wines)
        {
            return wines.Select(ToDto).ToList();
        }
    }
}
