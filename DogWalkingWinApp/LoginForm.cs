using DogWalkingWinApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogWalkingWinApp
{
    public partial class LoginForm : Form
    {
        ILoginController _loginController;
        public LoginForm(ILoginController loginController)
        {
            InitializeComponent();
            _loginController = loginController;
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            if (_loginController.Login(_txtUserName.Text, _txtPassword.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid user or password.");
            }
        }
    }
}
