using DogWalkingWinApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DogWalkingWinApp.Data
{
    public class DogWalkingDbContext : DbContext
    {
        public DbSet<DogWalk> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DogWaling;Trusted_Connection=True;");
        }
    }
}
