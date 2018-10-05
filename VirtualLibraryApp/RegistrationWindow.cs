using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VirtualLibraryApp
{
    public partial class RegistrationWindow : Form
    {
        //stringas parodo kurioje direktorijoje yra DB
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                                  System.IO.Directory.GetParent(@"../ ").FullName +
                                  @"\Data\userdata.mdf;Integrated Security=True;Connect Timeout=30";
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

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UserAdd", sqlConnection);
                    // Turetu naudoti prie Stored Procedures esanti "UserAdd" bet meta errora kad Stored Procedure Not Found nors ji yra prie Stored Procedures
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // I tam tikrus laukus irasoma nauja informacija
                    sqlCommand.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Password", passwordTextBox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@LastName", lastNameTextBox.Text.Trim());
                    // Meta errora !!!!!!!!!!!!!!!
                    sqlCommand.ExecuteNonQuery();
                    //!!!!!!!!!!!!!!!!!!
                    MessageBox.Show("Registration is successful");
                    //Laukai isvalomi
                    Clear();

                    //Grizta i login screen
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }

            }
        }

        void Clear()
        {
            usernameTextBox.Text = passwordTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = confirmPasswordTextBox.Text ="";
        }
        
    }
}
