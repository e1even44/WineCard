using DigitalWineCard.Data.CSV.CsvDtos;
using DigitalWineCard.Data.Entities;
using DigitalWineCard.Data.UI.UIDtos;

namespace DigitalWineCard.Core.AccessLayers
{
    public class WineAccessLayer : BaseAccessLayer<Wine>
    {
        public override List<Wine> GetAll()
        {
            return _dbContext.Wines
                .ToList();
        }

        public override Wine GetById(int? id)
        {
            if (id is null)
            {
                return new Wine();
            }         
            
            return _dbContext.Wines
                .FirstOrDefault(w => w.WineId == id);
        }

        public List<Wine> GetOnlyActive()
        {
            return _dbContext.Wines
                .Where(w => w.IsActive)
                .ToList();
        }

        public int GetActiveWinesAmount()
        {
            return _dbContext.Wines
                .Where(w => w.IsActive)
                .ToList().Count;
        }

        /// <summary>
        /// Checks if keywords that the user searches for match either type, country of origin or year of wine.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>A list of wines that match the searched keywords. Empty list if no matches found.</returns>
        public List<Wine> GetByFilters(string filter)
        {
            return _dbContext.Wines
                .Where(w =>
                w.Type.ToLower().Contains(filter.ToLower())
                || w.CountryOfOrigin.ToLower().Contains(filter.ToLower())
                || w.Year.ToString().Contains(filter))
                .ToList();
        }

        public override void Add(Wine entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(int id, Wine entity)
        {
            var w = _dbContext.Wines
                .FirstOrDefault(w => w.WineId == id);

            w.Name = entity.Name;
            w.Type = entity.Type;
            w.Description = entity.Description;
            w.CountryOfOrigin = entity.CountryOfOrigin;
            w.Year = entity.Year;
            w.LiterPriceInEuro = entity.LiterPriceInEuro;
            w.ImportId = entity.ImportId;
            w.IsActive = entity.IsActive;

            _dbContext.SaveChanges();
        }

        public override void Delete(int id)
        {
            _dbContext.Wines.Remove(GetById(id));
            _dbContext.SaveChanges();
        }

        public bool WineAlreadyExists(WineCsvDto wine)
        {
            return _dbContext.Wines
                .Where(w => w.Name == wine.Name
                && w.Year == w.Year
                && w.CountryOfOrigin == w.CountryOfOrigin)
                .Any();
        }

        public bool WineAlreadyExists(Wine wine)
        {
            return _dbContext.Wines
                .Where(w => w.Name == wine.Name
                && w.Year == w.Year
                && w.CountryOfOrigin == w.CountryOfOrigin)
                .Any();
        }

        public bool WineAlreadyExists(WineUiDto wine)
        {
            return _dbContext.Wines
                .Where(w => w.Name == wine.Name
                && w.Year == w.Year
                && w.CountryOfOrigin == w.CountryOfOrigin)
                .Any();
        }

        public void DeactivateWine(int id)
        {
            var w = _dbContext.Wines
                  .FirstOrDefault(w => w.WineId == id);

            w.IsActive = false;
            _dbContext.SaveChanges();
        }
    }
}
