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
            _context.DogWalks.Add(dogWalk);
            _context.SaveChanges();
        }

        public void Delete(DogWalk dogWalk)
        {
            _context.DogWalks.Remove(dogWalk);
            _context.SaveChanges();
        }

        public List<DogWalk> GetAll()
        {
            return _context.DogWalks.ToList();
        }

        public void Update(DogWalk dogWalk)
        {
            _context.DogWalks.Update(dogWalk);
            _context.SaveChanges();
        }

        public List<DogWalk> Search(SearchCriteria query)
        {
            var queryResult = _context.DogWalks.AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.ClientName))
            {
                queryResult = queryResult.Where(c => c.ClientName.Contains(query.ClientName));
            }

            if (!string.IsNullOrWhiteSpace(query.DogName))
            {
                queryResult = queryResult.Where(c => c.DogName.Contains(query.DogName));
            }

            var result = queryResult.ToList();

            return result;
        }
    }
}
