using System;
using Logic;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class RegistrationForm : Form, IRegistration
    {
		public event Action ButtonPressed;

		public string Username => usernameTextBox.Text;
		public string Password => passwordTextBox.Text;
		public string ConfirmPassword => confirmPasswordTextBox.Text;
		public string Firstname => firstNameTextBox.Text;
		public string Lastname => lastNameTextBox.Text;

		public RegistrationForm()
        {
            InitializeComponent();
        }

		private void createAccountButton_Click(object sender, EventArgs e)
		{
			ButtonPressed();
		}

		public void OnRegistrationSuccess()
		{
			MessageBox.Show("Registration is successful");

			//Grizta i login screen
			this.Close();

			//Laukai isvalomi
			Clear();
		}

		public void OnError(string message)
		{
			MessageBox.Show(message);
		}

		private void Clear()
        {
            usernameTextBox.Text = passwordTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = confirmPasswordTextBox.Text = "";
        }

		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
