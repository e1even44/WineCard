using DigitalWineCard.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigitalWineCard.Data
{
    public class DigitalWineCardDbContext : DbContext
    {
        // db tables
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<ImportLog> ImportLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // relative path to the local mssql database file
                // best case would be to use a connection string from a configuration file
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=DigitalWineCardDB;Trusted_Connection=True;");
            }
        }
    }
}
