using DogWalkingWinApp.ViewModel;

namespace DogWalkingWinApp
{
    public partial class FormDogWalks : System.Windows.Forms.Form
    {
        IDogWalkController _controller;
        public FormDogWalks(IDogWalkView dogWalkView, IDogWalkListView dogWalkList, IDogWalkController controller)
        {
            InitializeComponent();
            _controller = controller;

            _pnlTop.Controls.Add(dogWalkView as Control);
            _pnlBottom.Controls.Add(dogWalkList as Control);
        }

        private void FormDogWalks_Load(object sender, EventArgs e)
        {
            _controller.Show();
        }

        private void _btnNew_Click(object sender, EventArgs e)
        {
            _controller.New();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            _controller.Save();
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            _controller.Search(new Repositories.SearchCriteria(_txtClientName.Text, _txtDogName.Text));
        }

        private void _btnClearSearch_Click(object sender, EventArgs e)
        {
            _txtDogName.Text = _txtClientName.Text = string.Empty;
            _btnSearch.PerformClick();
        }
    }
}
