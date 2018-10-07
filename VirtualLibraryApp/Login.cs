using System;
using System.Data;
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

            //Tikriname ar ivesti duomenis atitinka su sql duomenu bazeje esanciais vartotojo duomenimis.
            DataTable data = SQLConnection.SelectQuery("SELECT * FROM Users WHERE username = '" +
                                                        UsernameTextBox.Text + "' AND password = '" +
                                                        PasswordTextBox.Text + "';");

			//Jei vartotojo ivestas vardas ir slaptazodis atitiko, atidaromas meniu langas, kitu atveju 
			//lentele, kad duomenys blogi.
			if (data.Rows.Count > 0)
			{
				this.Hide();
				Main mainMenu = new Main();
				mainMenu.Show();
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password. Please, try again.");
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

        private void newAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }
    }
}
