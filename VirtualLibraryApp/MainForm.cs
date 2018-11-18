using System;
using System.Windows.Forms;
using Logic;

namespace VirtualLibraryApp
{
	public partial class MainForm : Form
	{
        User User { get; set; }
		public MainForm(User User)
		{
            this.User = User;
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//Tikrina ar prisijunge administratorius, jei taip, tai atsiranda papildoma funkcija prideti knygas
			if(User.IsAdmin)

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
			//Paspaudus skenuoti, bus atidarytas naujas langas, kuriame bus galima pasirinkti barcode
			//(Vėliau bus pakeista į kameros skenavima).
			this.Hide();
	///		CameraScreen cameraMenu = new CameraScreen(User);
	//		cameraMenu.ShowDialog();
            this.Show();
		}

		private void SearchBook_Click(object sender, EventArgs e)
		{
			this.Hide();
	//		SearchBook searchBookMenu = new SearchBook(User);
	//		searchBookMenu.ShowDialog();
            this.Show();
		}
	
		private void AddBook_Click(object sender, EventArgs e)
		{
			this.Hide();
	//		AddBook addBookMenu = new AddBook(User);
	//		addBookMenu.ShowDialog();
            this.Show();
		}

        private void lastSearchesButton_Click(object sender, EventArgs e)
        {
      //      LastSearches ls = new LastSearches(User);
            this.Hide();
      //      ls.ShowDialog();
            this.Show();
        }

		private void MissingBooks_Click(object sender, EventArgs e)
		{
			this.Hide();
		//	MissingBooks missingBooksMenu = new MissingBooks(User);
		//	missingBooksMenu.ShowDialog();
			this.Show();
		}

		private void LogOut_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
