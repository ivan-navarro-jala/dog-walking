using DogWalkingWinApp.Data;
using DogWalkingWinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingWinApp.Repositories
{
    public class DogWalkRepository : IDogWalkRepository
    {
        private readonly DogWalkingDbContext _context;

        public DogWalkRepository(DogWalkingDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public void Add(DogWalk dogWalk)
        {
            throw new NotImplementedException();
        }

        public void Delete(DogWalk dogWalk)
        {
            throw new NotImplementedException();
        }

        public List<DogWalk> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(DogWalk dogWalk)
        {
            throw new NotImplementedException();
        }
    }
}
