using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Logic;

namespace VirtualLibraryApp
{
	public partial class LoginForm : Form	{

		private Login login;
		private LoginDataProvider loginData;

		public LoginForm()
		{
			InitializeComponent();
			login = new Login();
			loginData = new LoginDataProvider();
		}

		private void SignInButton_Click_1(object sender, EventArgs e)
		{
			login.LoginCheck(UsernameTextBox.Text, PasswordTextBox.Text, loginData);

			if(loginData.correctData)
			{
				UsernameTextBox.Text = "";
				PasswordTextBox.Text = "";
				Navigation.OpenMainMenu(this, loginData.user);
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password. Please, try again.");
			}
		}

		private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Navigation.OpenRegistrationMenu(this);
        }
	}
}
