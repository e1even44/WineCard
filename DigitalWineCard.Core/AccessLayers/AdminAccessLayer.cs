using DigitalWineCard.Data.Entities;

namespace DigitalWineCard.Core.AccessLayers
{
    public class AdminAccessLayer : BaseAccessLayer<Admin>
    {
        public override List<Admin> GetAll()
        {
            return _dbContext.Admins
                .ToList();
        }

        public override Admin GetById(int? id)
        {
            if (id is null)
            {
                return new Admin();
            }

            return _dbContext.Admins
                .FirstOrDefault(a => a.AdminId == id);
        }

        public override void Add(Admin entity)
        {
            _dbContext.Admins.Add(entity);
            _dbContext.SaveChanges();
        }

        public override void Delete(int id)
        {
          _dbContext.Admins.Remove(GetById(id));
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Checks if there is already "test-admins" in the database.
        /// </summary>
        /// <returns>True if admins already exist, false if table is empty.</returns>
        public bool AdminsExist()
        {
            return _dbContext.Admins.Any();
        }

        public Admin GetByUsername(string username)
        {
            return _dbContext.Admins
                 .FirstOrDefault(a => a.Username == username);
        }

        public bool UsernameExists(string username)
        {
            return _dbContext.Admins
                 .Any(a => a.Username == username);
        }
    }
}
