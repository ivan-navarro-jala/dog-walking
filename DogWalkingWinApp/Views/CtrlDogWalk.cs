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
    public partial class CtrlDogWalk : UserControl, IDogWalkView
    {
        public CtrlDogWalk()
        {
            InitializeComponent();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
