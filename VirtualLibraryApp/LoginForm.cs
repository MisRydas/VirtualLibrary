using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Logic;

namespace VirtualLibraryApp
{
	public partial class LoginForm : Form, ILogin
    {
        public event Action ButtonPressed;

		public string Username => UsernameTextBox.Text;
        public string Password => PasswordTextBox.Text;

        public LoginForm()
		{
			InitializeComponent();
		}

		private void SignInButton_Click_1(object sender, EventArgs e)
		{
            ButtonPressed();
        }

		private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Navigation.OpenRegistrationMenu(this);
        }

        public void OnLoginSuccess(User user)
        {
			Navigation.OpenMainMenu(this, user);
        }

        public void OnError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
