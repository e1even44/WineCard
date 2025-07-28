using DigitalWineCard.Data;

namespace DigitalWineCard.Core.AccessLayers
{
    public abstract class BaseAccessLayer<T>
    {
        protected DigitalWineCardDbContext _dbContext = new();
  
        public abstract List<T> GetAll();
        public abstract T GetById(int? id);
        public abstract void Add(T entity);
        public abstract void Delete(int id);
    }
}
