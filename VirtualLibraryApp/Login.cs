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
			//sql serverio radimas. "System.IO.Directory.GetParent(@"../ ").FullName" randa projecto adresa kompiuteryje 
			//pvz.: "C:\Users\Tadas\Desktop\VirtualLibraryApp\bin" ir tada projekte randa duomenu faila, 
			//kur yra visi vartotoju vardai ir slaptazodziai.
			SqlConnection sqlConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
														System.IO.Directory.GetParent(@"../ ").FullName + 
														@"\Data\userdata.mdf;Integrated Security=True;Connect Timeout=30");

			//Tikriname ar ivesti duomenis atitinka su sql duomenu bazeje esanciais vartotojo duomenimis.
			SqlDataAdapter sqlData = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username = '" + 
														UsernameTextBox.Text + "' AND password = '" + 
														PasswordTextBox.Text + "'", sqlConnect);

			//Sukuriame nauja duomenu lentele ir ja uzpildome skaiciu 1(jei vartotojas ivede teisingus duomenis) 
			//arba 0(jei duomenys neteisingi).
			DataTable data = new DataTable();
			sqlData.Fill(data);

			//Jei vartotojo ivestas vardas ir slaptazodis atitiko, atidaromas meniu langas, kitu atveju 
			//lentele, kad duomenys blogi.
			if (data.Rows[0][0].ToString() == "1")
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
	}
}
