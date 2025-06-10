using DogWalkingWinApp.Models;
using DogWalkingWinApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingWinApp.ViewModel
{
    public interface IDogWalkController
    {
        void New();

        void Delete();
        
        void Search(SearchCriteria query);
        void Show();
        void Save();
    }
}
