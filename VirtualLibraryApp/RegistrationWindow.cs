using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
    delegate void CreateAccount(string u, string p, string f, string l);

	public partial class RegistrationWindow : Form
    {
		public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount crAcc = new CreateAccount(CreateAcc);
            crAcc(usernameTextBox.Text, passwordTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
                //Grizta i login screen
                this.Close();
            
        }

        private void CreateAcc(string u, string p, string f, string l)
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

                if (!regex.IsMatch(Password))
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
            }

        }
        void Clear()
        {
            usernameTextBox.Text = passwordTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = confirmPasswordTextBox.Text ="";
        }

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        public bool CheckFirstName(String FirstName)
        {
            String empty = "";

            return empty != FirstName ? true : false;
        }

        public bool CheckLastName(String LastName)
        {
            String empty = "";

            return empty != LastName ? true : false;
        }

        public bool CheckPassword(String Password)
        {
            Regex regex;
            regex = new Regex(@"^(?=(.*\d){1})(?=.*[a-z])(?=.*[A-Z]).{8,}$");

            return regex.IsMatch(Password.ToString()) ? true : false;
        }
        public bool CheckUsername(String Username)
        {
            Regex regex;
            regex = new Regex(@"^(?=(.*\d){1})(?=.*[a-z])(?=.*[A-Z]).{8,}$");

            return regex.IsMatch(Username.ToString()) ? true : false;
        }
    }
}
