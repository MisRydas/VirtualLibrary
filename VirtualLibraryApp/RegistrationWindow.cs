using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class RegistrationWindow : Form
    {
		//Sukuriam nauja delegata eventui.
		public delegate void EventHandler(string u, string p, string c, string f, string l);

		//Sukuriam eventa.
		public event EventHandler CreateEvent;

		public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
			//Pridedam registracijos eventa.
			CreateEvent = new EventHandler(CreateAcc);
			//Paleidziam eventa.
			CreateEvent.Invoke(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
		}

		//delegate
		public void CreateAcc(string username, string password, string cPassword, string firstname, string lastname)
		{
			// Jei buvo paliktas bent vienas tuscias laukas, programa meta errora
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cPassword) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
			{
				MessageBox.Show("Please fill mandatory fields");
			}
			// Jei passwordai nevienodi programa meta errora
			else if (password != cPassword)
			{
				MessageBox.Show("Passwords do not match");
			}
			// Jei visi laukai irasyti ir slaptazodziai sutampa, tuomet programa i DB iraso naujo vartuotojo duomenis
			else
			{
				//Nusiskaitomos reikšmės iš textboxų
				String UserName = username.Trim();
				String Password = password.Trim();

				Regex regex;

				regex = new Regex(@"^(?=(.*\d){1})(?=.*[a-z])(?=.*[A-Z]).{8,}$");

				if (!regex.IsMatch(Password))
				{
					MessageBox.Show("Password must have at least 8 Symbols, 1 lowercase, 1 uppercase and 1 number. Please, correct your password.");
					return;
				}
				else
				{
					String FirstName = firstname.Trim();
					String LastName = lastname.Trim();
					//Pridedamas useris į DB
					SQLConnection.AddNewUser(UserName, Password, FirstName, LastName);
					MessageBox.Show("Registration is successful");

					//Grizta i login screen
					this.Close();

					//Laukai isvalomi
					Clear();
				}
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
