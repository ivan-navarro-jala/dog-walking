using DogWalkingWinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingWinApp.ViewModel
{
    public interface IDogWalkView
    {
        event EventHandler<DogWalk> DogWalkSaved;

        void Delete();
        void Edit(DogWalk dogWalk);
        void New();
        void Save();
    }
}
