using DogWalkingWinApp.Models;
using DogWalkingWinApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogWalkingWinApp.Views
{
    public partial class CtrlDogWalkList : UserControl, IDogWalkListView
    {
        public CtrlDogWalkList()
        {
            InitializeComponent();
        }

        public void Show(List<DogWalk> dogWalks)
        {
            _dgvDogWalks.DataSource = dogWalks;
        }
    }
}
