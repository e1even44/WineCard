using DigitalWineCard.Data.Entities;

namespace DigitalWineCard.Core.AccessLayers
{
    public class ImportLogAccessLayer : BaseAccessLayer<ImportLog>
    {
        public override List<ImportLog> GetAll()
        {
            return _dbContext.ImportLogs
                .ToList();
        }

        public override ImportLog GetById(int? id)
        {
            if (id is null)
            {
                return new ImportLog();
            }

            return _dbContext.ImportLogs
            .FirstOrDefault(i => i.ImportId == id);
        }

        public override void Add(ImportLog entity)
        {
            _dbContext.ImportLogs.Add(entity);
            _dbContext.SaveChanges();
        }
        
        public override void Delete(int id)
        {
            _dbContext.ImportLogs.Remove(GetById(id));
            _dbContext.SaveChanges();
        }
    }
}
