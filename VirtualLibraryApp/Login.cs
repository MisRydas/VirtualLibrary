using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VirtualLibraryApp
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void UsernameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void SignInButton_Click_1(object sender, EventArgs e)
		{

			DataTable userData = SQLConnection.SelectQuery("SELECT * FROM Users");

			var userLogin = from user in userData.AsEnumerable() where user.Field<string>("username") == UsernameTextBox.Text && user.Field<string>("password") == PasswordTextBox.Text select user;

			DataView result = userLogin.AsDataView();

			//Jei vartotojo ivestas vardas ir slaptazodis atitiko, atidaromas meniu langas, kitu atveju 
			//lentele, kad duomenys blogi.
						if (result.Count == 1)
						{
							this.Hide();
							Main mainMenu = new Main(SQLConnection.GetUserById((int)result[0]["Id"]));
							mainMenu.Show();
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
            registrationWindow.Show();
        }
    }
}
