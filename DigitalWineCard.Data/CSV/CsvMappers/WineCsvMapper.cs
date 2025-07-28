using DigitalWineCard.Data.CSV.CsvDtos;
using CsvHelper.Configuration;

namespace DigitalWineCard.Data.CSV.CsvMappers
{
    public class WineCsvMapper : ClassMap<WineCsvDto>
    {
        public WineCsvMapper()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.Weinsorte).Name("Weinsorte");
            Map(m => m.Herkunftsland).Name("Herkunftsland");
            Map(m => m.Jahrgang).Name("Jahrgang");
            Map(m => m.Beschreibung).Name("Beschreibung");
            Map(m => m.Preis).Name("Preis");
        }
    }
}
