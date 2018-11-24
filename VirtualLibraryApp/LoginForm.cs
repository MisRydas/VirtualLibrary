using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Logic;

namespace VirtualLibraryApp
{
	public partial class LoginForm : Form, ILoginView
    {

		Login login;
        //LoginDataProvider loginData => null;
        public event Action ButtonPressed;
        public string Username => UsernameTextBox.Text;
        public string Password => PasswordTextBox.Text;

        //LoginDataProvider loginData;
        public LoginForm(Login login)
		{
            login = this.login;
			InitializeComponent();
			//login = new Login();
			//loginData = new LoginDataProvider();
		}

		private void SignInButton_Click_1(object sender, EventArgs e)
		{
            ButtonPressed();//pls work
            //buves kodas
            //login.LoginCheck(UsernameTextBox.Text, PasswordTextBox.Text, loginData);

            //if(loginData.correctData)
            //{
            //	UsernameTextBox.Text = "";
            //	PasswordTextBox.Text = "";
            //	Navigation.OpenMainMenu(this, loginData.user);
            //}
            //else
            //{
            //	MessageBox.Show("Incorrect Username or Password. Please, try again.");
            //}
        }

		private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Navigation.OpenRegistrationMenu(this);
        }
        public void OnLoginSuccess()
        {
            this.Close();
            Show();
        }
        public void OnError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
