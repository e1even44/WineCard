namespace DigitalWineCard.Data.CSV.CsvDtos
{
    public class WineCsvDto
    {
        public string Name { get; set; } = string.Empty;

        public string Weinsorte { get; set; } = string.Empty;

        public string Herkunftsland { get; set; } = string.Empty;

        public int Jahrgang { get; set; }

        public string Beschreibung { get; set; } = string.Empty;

        public double Preis { get; set; }
    }
}
