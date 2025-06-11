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
        public event EventHandler<DogWalk> DogWalkSelected;
        public CtrlDogWalkList()
        {
            InitializeComponent();
        }

        public void Show(List<DogWalk> dogWalks)
        {
            _dgvDogWalks.DataSource = dogWalks;
        }

        private void _dgvDogWalks_SelectionChanged(object sender, EventArgs e)
        {
            if (_dgvDogWalks.SelectedRows.Count==0)
            {
                return;
            }
            var selectedDogWalk = _dgvDogWalks.SelectedRows[0].DataBoundItem as DogWalk;

            DogWalkSelected(this, selectedDogWalk);
        }
    }
}
