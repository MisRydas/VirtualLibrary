using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
    public partial class RegistrationWindow : Form
    {
        //stringas parodo kurioje direktorijoje yra DB
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                                  System.IO.Directory.GetParent(@"../ ").FullName +
                                  @"\Data\UserDB.mdf;Integrated Security=True;Connect Timeout=30";
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
        
    }
}
