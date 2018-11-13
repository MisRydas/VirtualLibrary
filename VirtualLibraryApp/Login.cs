using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static VirtualLibraryApp.SQLConnection;

delegate void CheckData(int i, string s);
delegate DataView LogInD();
namespace VirtualLibraryApp
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			if(Properties.Settings.Default.RememberMe)
			{
				this.RememberMe.Checked = true;
				this.UsernameTextBox.Text = Properties.Settings.Default.Username;
				this.PasswordTextBox.Text = Properties.Settings.Default.Password;
			}
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
            DataView result;
            LogInD logIn = new LogInD(LogInDeleg);

            //delegato instatntiate'inimas naudojant lamba expression
            result = logIn();

            CheckData chd = (i, s) =>
            {
                if (i == 1)
                {
					if (RememberMe.Checked)
					{
						Properties.Settings.Default.Username = UsernameTextBox.Text;
						Properties.Settings.Default.Password = PasswordTextBox.Text;
						Properties.Settings.Default.Save();
					}
					else
					{
						UsernameTextBox.Text = "";
						PasswordTextBox.Text = "";
					}
                    this.Hide();
                    Main mainMenu = new Main(SQLConnection.GetUserById((int)result[0]["Id"]));
                    mainMenu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(s);
                }
            };

            chd(result.Count, "Incorrect Username or Password. Please, try again.");

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
