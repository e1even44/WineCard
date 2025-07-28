using CsvHelper;
using CsvHelper.Configuration;
using DigitalWineCard.Data;
using DigitalWineCard.Data.CSV.CsvDtos;
using DigitalWineCard.Data.CSV.CsvMappers;
using DigitalWineCard.Data.Entities;
using System.Globalization;

namespace DigitalWineCard.Core.Managers
{
    public class CsvManager
    {
        private static readonly DigitalWineCardDbContext _dbContext = new();

        public static List<WineCsvDto> ReadWineCsv(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                Encoding = System.Text.Encoding.UTF8
            });

            csv.Context.RegisterClassMap<WineCsvMapper>();
            return csv.GetRecords<WineCsvDto>().ToList();
        }

        public static void ImportWinesFromCsv(string filePath)
        {
            var csvRecords = ReadWineCsv(filePath);

            foreach (var record in csvRecords)
            {
                var wine = new Wine
                {
                    Name = record.Name,
                    Type = record.Weinsorte,
                    CountryOfOrigin = record.Herkunftsland,
                    Year = record.Jahrgang,
                    Description = record.Beschreibung,
                    LiterPriceInEuro = record.Preis,
                    IsActive = true
                };

                _dbContext.Wines.Add(wine);
            }
            _dbContext.SaveChanges();
        }
    }
}