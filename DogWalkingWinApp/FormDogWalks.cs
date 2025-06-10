using DogWalkingWinApp.ViewModel;

namespace DogWalkingWinApp
{
    public partial class FormDogWalks : System.Windows.Forms.Form
    {
        public FormDogWalks(IDogWalkView dogWalkView)
        {
            InitializeComponent();

            _pnlTop.Controls.Add(dogWalkView as Control);
        }
    }
}
