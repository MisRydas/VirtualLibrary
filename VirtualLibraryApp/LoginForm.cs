using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Logic;
using static VirtualLibraryApp.SQLConnection;

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
		//	login.ThrowLoginEvent += (username, password, eventArg) => { login.LoginCheck(username, password, eventArg); };
			login.LoginCheck(UsernameTextBox.Text, PasswordTextBox.Text, loginData);

			if(loginData.correctData)
			{
				UsernameTextBox.Text = "";
				PasswordTextBox.Text = "";
				Navigation.LoadUser(loginData.user);
				Navigation.OpenMenu("MainForm", this, true);
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password. Please, try again.");
			}
		}

		private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Navigation.OpenMenu("RegistrationForm", this, false);
        }
	}
}
