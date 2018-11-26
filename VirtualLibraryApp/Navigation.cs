using System;
using System.Data;
using System.Windows.Forms;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibraryApp
{
	class Navigation
	{
		public static void OpenMainMenu(Form senderMenu, User user)
		{
			senderMenu.Hide();
			MainForm mainMenu = new MainForm(user);
			mainMenu.ShowDialog();
			senderMenu.Show();
		}
		public static void OpenRegistrationMenu(Form senderMenu)
		{
			senderMenu.Hide();
			RegistrationForm registrationMenu = new RegistrationForm();
			Registration registration = new Registration(registrationMenu);
			registrationMenu.ShowDialog();
			senderMenu.Show();
		}
		public static void OpenCameraMenu(Form senderMenu, User user)
		{
			senderMenu.Hide();
			CameraForm cameraMenu = new CameraForm(user);
			cameraMenu.ShowDialog();
			senderMenu.Show();
		}
		public static void OpenBookMenu(Form senderMenu, DataView bookData, int book)
		{
			senderMenu.Hide();
			BookForm bookMenu = new BookForm(bookData, book);
			bookMenu.ShowDialog();
			senderMenu.Show();
		}
		public static void OpenLastSearchesMenu(Form senderMenu)
		{
			senderMenu.Hide();
			LastSearchesForm lastSearchesMenu = new LastSearchesForm();
			LastSearches lastSearches = new LastSearches(lastSearchesMenu);
			lastSearchesMenu.LoadSearch();
			lastSearchesMenu.ShowDialog();
			senderMenu.Show();
		}
		public static void OpenAddBookMenu(Form senderMenu, User user)
		{
			senderMenu.Hide();
			AddBookForm addBookMenu = new AddBookForm(user);
            AddBook  nu = new AddBook(addBookMenu);
			addBookMenu.ShowDialog();
			senderMenu.Show();
		}
		public static void OpenMissingBooksMenu(Form senderMenu, User user)
		{
			senderMenu.Hide();
			MissingBooksForm missingBooksMenu = new MissingBooksForm(user);
			missingBooksMenu.ShowDialog();
			senderMenu.Show();
		}
		public static void OpenSearchBookMenu(Form senderMenu, User user)
		{
			senderMenu.Hide();
			SearchBookForm searchBookMenu = new SearchBookForm(user);
			searchBookMenu.ShowDialog();
			senderMenu.Show();
		}
	} 
}
