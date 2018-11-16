using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VirtualLibraryCode;
using static VirtualLibraryApp.SQLConnection;

namespace VirtualLibraryApp
{
	public partial class Login : Form	{

		private LoginCode loginCode;
		private LoginEventsArgs eventArgs;

		public Login()
		{
			InitializeComponent();
			loginCode = new LoginCode();
			eventArgs = new LoginEventsArgs();
		}


		private void SignInButton_Click_1(object sender, EventArgs e)
		{
			loginCode.ThrowLoginEvent += (username, password, eventArg) => { loginCode.LoginCheck(username, password, eventArg); };
			loginCode.LoginCheck(UsernameTextBox.Text, PasswordTextBox.Text, eventArgs);

			if(eventArgs.correctData)
			{
				UsernameTextBox.Text = "";
				PasswordTextBox.Text = "";
				this.Hide();
				Main mainMenu = new Main(SQLConnection.GetUserById((int)eventArgs.result[0]["Id"])); //Bus pakeista i eventArgs.user
				mainMenu.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password. Please, try again.");
			}
		}

		private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
            this.Show();
        }
        //delegates
        private DataView LogInDeleg()
        {
            //Gaunam informacija apie naudotojus is sql serverio
            DataTable userData = GetAllUsersInDataTable();

            //Tikriname ar yra toks vartotojas duomenu bazeje
            var userLogin = from user in userData.AsEnumerable() where user.Field<string>("username") == UsernameTextBox.Text && user.Field<string>("password") == PasswordTextBox.Text select user;

            //Gauname informacija apie vartotoja, jei toks buvo rastas
            DataView result = userLogin.AsDataView();
            return result;
        }
        public bool CheckLogin (String username, String password)
        {
            DataTable userData = GetAllUsersInDataTable();
            var userLogin = from user in userData.AsEnumerable() where user.Field<string>("username") == username && user.Field<string>("password") == password select user;
            DataView result = userLogin.AsDataView();

            if (result.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

		private void RememberMe_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.RememberMe = this.RememberMe.Checked;
			Properties.Settings.Default.Save();
		}
	}
}
