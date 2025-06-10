using DogWalkingWinApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DogWalkingWinApp.Data
{
    public class DogWalkingDbContext : DbContext
    {
        public DbSet<DogWalk> Clients { get; set; }

        public DogWalkingDbContext(DbContextOptions<DogWalkingDbContext> options) : base(options) { }
    }
}
