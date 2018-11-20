using System;
using Logic;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class RegistrationForm : Form
    {
		Registration registration;
		RegistrationDataProvider registrationData;

		public RegistrationForm()
        {
            InitializeComponent();
			registrationData = new RegistrationDataProvider();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
			registration = new Registration(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text,
											firstNameTextBox.Text, lastNameTextBox.Text, registrationData);

			//	registration.CreateAccount(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text, 
			//								firstNameTextBox.Text, lastNameTextBox.Text, registrationData);

			if (registrationData.emptyFields)
			{
				MessageBox.Show("Please fill mandatory fields");
			}
			else if(registrationData.passwordsDontMatch)
			{
				MessageBox.Show("Passwords do not match");
			}
			else if(registrationData.passwordIsNotCorrect)
			{
				MessageBox.Show("Password must have at least 8 Symbols, 1 lowercase, 1 uppercase and 1 number. Please, correct your password.");
			}
			else
			{
				MessageBox.Show("Registration is successful");

				//Grizta i login screen
				this.Close();

				//Laukai isvalomi
				Clear();
			}

			//Pridedam registracijos eventa.
			//	CreateEvent = new EventHandler(CreateAcc);
			//Paleidziam eventa.
			//	CreateEvent.Invoke(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
		}

		void Clear()
        {
            usernameTextBox.Text = passwordTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = confirmPasswordTextBox.Text = "";
        }

		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
