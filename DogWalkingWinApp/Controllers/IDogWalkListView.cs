using DogWalkingWinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingWinApp.ViewModel
{
    public interface IDogWalkListView
    {
        void Show(List<DogWalk> dogWalks);
    }
}
