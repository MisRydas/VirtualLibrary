using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VirtualLibraryApp
{

	public partial class RegistrationWindow : Form
    {
		public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // Jei buvo paliktas bent vienas tuscias laukas, programa meta errora
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || firstNameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields");
            }
            // Jei passwordai nevienodi programa meta errora
            else if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            // Jei visi laukai irasyti ir slaptazodziai sutampa, tuomet programa i DB iraso naujo vartuotojo duomenis
            else
            {
                //Nusiskaitomos reikšmės iš textboxų
                String UserName = usernameTextBox.Text.Trim();
                String Password = passwordTextBox.Text.Trim();

				Regex regex;

				regex = new Regex(@"^(?=(.*\d){1})(?=.*[a-z])(?=.*[A-Z]).{8,}$");

				if(!regex.IsMatch(Password))
				{
					MessageBox.Show("Password must have at least 8 Symbols, 1 lowercase, 1 uppercase and 1 number. Please, correct your password.");
					return;
				}

				String FirstName = firstNameTextBox.Text.Trim();
                String LastName = lastNameTextBox.Text.Trim();
                //Pridedamas useris į DB
                SQLConnection.AddNewUser(UserName, Password, FirstName, LastName);
                MessageBox.Show("Registration is successful");
                //Laukai isvalomi
                Clear();

                //Grizta i login screen
                this.Hide();
                Login login = new Login();
                login.Show();

            }
        }

        void Clear()
        {
            usernameTextBox.Text = passwordTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = confirmPasswordTextBox.Text ="";
        }

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login loginMenu = new Login();
			loginMenu.Show();
		}
	}
}
