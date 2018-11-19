using System;
using System.Windows.Forms;
using Logic;

namespace VirtualLibraryApp
{
	public partial class MainForm : Form
	{
		User user;

		public MainForm(User user)
		{
            this.user = user;
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//Tikrina ar prisijunge administratorius, jei taip, tai atsiranda papildoma funkcija prideti knygas
			if(user.IsAdmin)

            {
				AddBook.Show();
				MissingBooks.Show();
			}
			else
			{
				AddBook.Hide();
				MissingBooks.Hide();
			}
		}

		private void CameraScanButton_Click(object sender, EventArgs e)
		{
			Navigation.OpenCameraMenu(this, user);
		}

		private void SearchBook_Click(object sender, EventArgs e)
		{
			Navigation.OpenSearchBookMenu(this, user);
		}
	
		private void AddBook_Click(object sender, EventArgs e)
		{
			Navigation.OpenAddBookMenu(this, user);
		}

		private void lastSearchesButton_Click(object sender, EventArgs e)
        {
			Navigation.OpenLastSearchesMenu(this, user);
        }

		private void MissingBooks_Click(object sender, EventArgs e)
		{
			Navigation.OpenMissingBooksMenu(this, user);
		}

		private void LogOut_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
