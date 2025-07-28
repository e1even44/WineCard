using DigitalWineCard.Data;
using DigitalWineCard.Data.Entities;

namespace DigitalWineCard.Core.Managers
{
    public class AdminManager
    {
        private static readonly DigitalWineCardDbContext _dbContext = new();

        public static void InitializeAdmins()
        {
            var passwordAdmin = PasswordManager.HashPassword("admin");
            var passwordAdmin1 = PasswordManager.HashPassword("admin1");
            var passwordAdmin2 = PasswordManager.HashPassword("admin2");

            var admin = new Admin
            {
                Username = "admin",
                Password = passwordAdmin.PasswordHash,
                Salt = passwordAdmin.Salt
            };


            var admin1 = new Admin
            {
                Username = "admin1",
                Password = passwordAdmin1.PasswordHash,
                Salt = passwordAdmin1.Salt
            };

            var admin2 = new Admin
            {
                Username = "admin2",
                Password = passwordAdmin2.PasswordHash,
                Salt = passwordAdmin2.Salt
            };
            
            _dbContext.Admins.Add(admin);
            _dbContext.Admins.Add(admin1);
            _dbContext.Admins.Add(admin2);

            _dbContext.SaveChanges();
        }
    }
}
