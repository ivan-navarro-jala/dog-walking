using DogWalkingWinApp.Models;

namespace DogWalkingWinApp.Repositories
{
    public interface IDogWalkRepository
    {
        List<DogWalk> GetAll();
        void Add(DogWalk dogWalk);
        void Update(DogWalk dogWalk);
        void Delete(DogWalk dogWalk);
        List<DogWalk> Search(SearchCriteria query);
        
    }
}
